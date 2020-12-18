# CuriH
## **C**ooperative **uri H**andler
# Motivation
As a .net developer I am often put in a situation in which I have to make small application to test and or configure my projects. 
In these applications the thing that I most often find myself spending absurd amounts off time on is enabling the user to select input and output files and or directories. 
The purpose of this package is to simplify the process of having the user specify files and or folders for varying I/O.


# Code concept 
ex. 


~~~
using Beryllium.UriHandler;

var handler = new UriHandler();
IList<ISuggetion<IDirectory>> recentDirectories  = handler.GetRecentDirectories(number = 10, user?);
IList<ISuggetion<iFile>> recentFiles = handler.GetRecentFiles(number = 10, user?);

using var fileStream = handler.GetWriteStream(recentDirectories[x], filename?);
...

using var readstream = handler.GetReadStream(DefaultPath.Home|tmp|etc, filename?);
...

~~~



# Interfaces

~~~

public Interface IUriHandler {

  GetRecentDirectories();
  GetRecentFiles();

  GetSuggestedFiles();
  GetSuggestedDriectories();

  GetDefaultDirectory();


  GetWriteStream();
  GetReadStream();

  AddToRecent();
}

~~~
