using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using CooperativeUriHandler.definitions.enums;
using CooperativeUriHandler.definitions.interfaces;
using CooperativeUriHandler.exceptions;
using CooperativeUriHandler.history;
using CooperativeUriHandler.implementations;
using CooperativeUriHandler.SystemLocationDefaults;

namespace CooperativeUriHandler
{
    public class UriHandler : IUriHandler
    {

        public UriHandler()
        {
            SetEnvironment();
        }
        public IHistory<IDirectory> DirectoryHistory { get; private set; } = new History<IDirectory>(new List<IDirectory>());
        public IHistory<IFile> FileHistory { get; private set; } = new History<IFile>(new List<IFile>());

        public IList<ISuggestion<IDirectory>> GetRecentDirectories(int amountToReturn = 10)
        {
            if (amountToReturn > 20)
                amountToReturn = 20;

            if (amountToReturn < 1)
                amountToReturn = 1;

            var output = DirectoryHistory.TypeHistory
                .TakeLast(amountToReturn)
                .Select(directory => new Suggestions<IDirectory>(directory))
                .Cast<ISuggestion<IDirectory>>()
                .ToList();

            return output;
        }

        public IList<ISuggestion<IFile>> GetRecentFiles(int amountToReturn = 10)
        {
            if (amountToReturn > 20)
                amountToReturn = 20;

            if (amountToReturn < 1)
                amountToReturn = 1;

            var output = FileHistory.TypeHistory
                .TakeLast(amountToReturn)
                .Select(file => new Suggestions<IFile>(file))
                .Cast<ISuggestion<IFile>>()
                .ToList();

            return output;
        }

        public void AddToRecent(IDirectory directory)
        {
            _ = directory ?? throw new ArgumentNullException(nameof(directory));
            DirectoryHistory.TypeHistory.Add(directory);
        }

        public void AddToRecent(ISuggestion<IDirectory> directory)
        {
            _ = directory ?? throw new ArgumentNullException(nameof(directory));
            _ = directory.Suggestion ?? throw new ArgumentNullException(nameof(directory.Suggestion));

            DirectoryHistory.TypeHistory.Add(directory.Suggestion);
        }

        public void AddToRecent(IFile file)
        {
            _ = file ?? throw new ArgumentNullException(nameof(file));
            FileHistory.TypeHistory.Add(file);
        }

        public void AddToRecent(ISuggestion<IFile> file)
        {
            _ = file ?? throw new ArgumentNullException(nameof(file));
            _ = file.Suggestion ?? throw new ArgumentNullException(nameof(file.Suggestion));

            FileHistory.TypeHistory.Add(file.Suggestion);
        }

        public void AddToRecent(Uri uri)
        {
            if (UriHelper.GetPositionType(uri) == PositionType.Directory)
            {
                var directory = new Directory(uri);
                DirectoryHistory.TypeHistory.Add(directory);
            }
            else if (UriHelper.GetPositionType(uri) == PositionType.File)
            {
                var file = new File(uri);
                FileHistory.TypeHistory.Add(file);
            }
        }

        //TODO: 
        public IDirectory GetDefaultDirectory(DefaultLocation defaultLocation)
        {
            throw new NotImplementedException();
        }

        private void SetEnvironment()
        {

            ISystemDefault currentDefault = null;

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                currentDefault = new LinuxLocationDefault("");

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                currentDefault = new WindowsLocationDefault("");

            _currentDefault = currentDefault ?? throw new RuntimeNotSupportedException(RuntimeInformation.OSDescription);
        }

        private ISystemDefault _currentDefault;

    }
}
