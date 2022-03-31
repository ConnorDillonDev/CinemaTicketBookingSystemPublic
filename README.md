
# Installation Guide

Information & installation guide.





## Installation

How to install the Dotnet & Python projects.

### Dotnet

Release can be found at:
```
CinemaTicketBookingSystemPublic\dbApps\WebApp\bin\Release\net6.0\win10-x64\WebApp.exe
```

Run from development enviroment (Visual Studio Code):
```
 - .NET 6.0 SDK(V6.0) must be installed (https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-6.0.201-windows-x64-installer)
 - File>Open Workspace from File
 - Naivtate to 'CinemaTicketBookingSystemPublic\dbApps\dbapps.code-workspace'
 - Select Terminal>New Terminal>WebApp
 - In the new terminal type "dotnet run" & enter
 - Finally connect to the localhost address displayed in the terminal
```


### Python
Run from development enviroment (PyCharm):
```
  - Python3 must be installed (https://www.python.org/downloads/)
  - PyCharm File>Open>CinemaTicketBookingSystemPublic\Python QR Scanner
  - File>Settings>Python Interpreter> '+' > search 'pip' > install package
  - Open a terminal in PyCharm located at the bottom of the screen "Terminal"
  - Run the following command : "pip install -r requirements.txt"
  - Run main
```
  *Note: Camera used for testing is a usb webcam of the bran Aukey*

    
## Demonstration

Example of the code operating can be found at:
```
https://www.youtube.com/watch?v=KKyfqA224yQ
```

### Sample Accounts

Example of accounts,  in order of highest permissions to lowest.
* Passwords not suitable for deployment *
```
SuperUser996@cinema.com : password 
StaffUser@gmail.com : password
standarduser@gmail.com : password

```


## Authors

- [@ConnorDillon](https://www.github.com/ConnorDillonDev)


## File Structure

CSProj


- Entites
```
Entities
 ┣ .vscode
 ┃ ┗ launch.json
 ┣ Archive
 ┣ bin
 ┃ ┣ Debug
 ┃ ┃ ┣ net6.0
 ┃ ┃ ┃ ┣ ref
 ┃ ┃ ┃ ┃ ┗ Entities.dll
 ┃ ┃ ┃ ┣ x64
 ┃ ┃ ┃ ┣ x86
 ┃ ┃ ┃ ┣ Entities.deps.json
 ┃ ┃ ┃ ┣ Entities.dll
 ┃ ┃ ┃ ┗ Entities.pdb
 ┃ ┃ ┗ netstandard2.1
 ┃ ┗ Release
 ┃ ┃ ┗ net6.0
 ┃ ┃ ┃ ┣ ref
 ┃ ┃ ┃ ┃ ┗ Entities.dll
 ┃ ┃ ┃ ┣ Entities.deps.json
 ┃ ┃ ┃ ┣ Entities.dll
 ┃ ┃ ┃ ┗ Entities.pdb
 ┣ obj
 ┃ ┣ Debug
 ┃ ┃ ┣ net6.0
 ┃ ┃ ┃ ┣ ref
 ┃ ┃ ┃ ┃ ┗ Entities.dll
 ┃ ┃ ┃ ┣ .NETCoreApp,Version=v6.0.AssemblyAttributes.cs
 ┃ ┃ ┃ ┣ Entities.AssemblyInfo.cs
 ┃ ┃ ┃ ┣ Entities.AssemblyInfoInputs.cache
 ┃ ┃ ┃ ┣ Entities.assets.cache
 ┃ ┃ ┃ ┣ Entities.csproj.AssemblyReference.cache
 ┃ ┃ ┃ ┣ Entities.csproj.CoreCompileInputs.cache
 ┃ ┃ ┃ ┣ Entities.csproj.FileListAbsolute.txt
 ┃ ┃ ┃ ┣ Entities.dll
 ┃ ┃ ┃ ┣ Entities.GeneratedMSBuildEditorConfig.editorconfig
 ┃ ┃ ┃ ┣ Entities.GlobalUsings.g.cs
 ┃ ┃ ┃ ┗ Entities.pdb
 ┃ ┃ ┗ netstandard2.1
 ┃ ┃ ┃ ┣ .NETStandard,Version=v2.1.AssemblyAttributes.cs
 ┃ ┃ ┃ ┣ Entities.AssemblyInfo.cs
 ┃ ┃ ┃ ┣ Entities.AssemblyInfoInputs.cache
 ┃ ┃ ┃ ┣ Entities.assets.cache
 ┃ ┃ ┃ ┣ Entities.csproj.AssemblyReference.cache
 ┃ ┃ ┃ ┣ Entities.csproj.CoreCompileInputs.cache
 ┃ ┃ ┃ ┣ Entities.csproj.FileListAbsolute.txt
 ┃ ┃ ┃ ┣ Entities.GeneratedMSBuildEditorConfig.editorconfig
 ┃ ┃ ┃ ┗ Entities.GlobalUsings.g.cs
 ┃ ┣ Release
 ┃ ┃ ┗ net6.0
 ┃ ┃ ┃ ┣ ref
 ┃ ┃ ┃ ┃ ┗ Entities.dll
 ┃ ┃ ┃ ┣ .NETCoreApp,Version=v6.0.AssemblyAttributes.cs
 ┃ ┃ ┃ ┣ Entities.AssemblyInfo.cs
 ┃ ┃ ┃ ┣ Entities.AssemblyInfoInputs.cache
 ┃ ┃ ┃ ┣ Entities.assets.cache
 ┃ ┃ ┃ ┣ Entities.csproj.CoreCompileInputs.cache
 ┃ ┃ ┃ ┣ Entities.csproj.FileListAbsolute.txt
 ┃ ┃ ┃ ┣ Entities.dll
 ┃ ┃ ┃ ┣ Entities.GeneratedMSBuildEditorConfig.editorconfig
 ┃ ┃ ┃ ┣ Entities.GlobalUsings.g.cs
 ┃ ┃ ┃ ┗ Entities.pdb
 ┃ ┣ Entities.csproj.nuget.dgspec.json
 ┃ ┣ Entities.csproj.nuget.g.props
 ┃ ┣ Entities.csproj.nuget.g.targets
 ┃ ┣ project.assets.json
 ┃ ┗ project.nuget.cache
 ┣ Account.cs
 ┣ Actor.cs
 ┣ ActorsMovieJunction.cs
 ┣ AgeRating.cs
 ┣ Booking.cs
 ┣ Building.cs
 ┣ Director.cs
 ┣ DirectorsMovieJunction.cs
 ┣ Entities.csproj
 ┣ Genre.cs
 ┣ Movie.cs
 ┣ PossibleDiscount.cs
 ┣ PossibleDiscountShowingJunction.cs
 ┣ Showing.cs
 ┗ Theatre.cs
```

- Context 
```
Context
 ┣ bin
 ┃ ┣ Debug
 ┃ ┃ ┗ net6.0
 ┃ ┃ ┃ ┣ ref
 ┃ ┃ ┃ ┃ ┗ Context.dll
 ┃ ┃ ┃ ┣ x64
 ┃ ┃ ┃ ┣ x86
 ┃ ┃ ┃ ┣ Context.deps.json
 ┃ ┃ ┃ ┣ Context.dll
 ┃ ┃ ┃ ┣ Context.pdb
 ┃ ┃ ┃ ┣ Entities.dll
 ┃ ┃ ┃ ┗ Entities.pdb
 ┃ ┗ Release
 ┃ ┃ ┗ net6.0
 ┃ ┃ ┃ ┣ ref
 ┃ ┃ ┃ ┃ ┗ Context.dll
 ┃ ┃ ┃ ┣ Context.deps.json
 ┃ ┃ ┃ ┣ Context.dll
 ┃ ┃ ┃ ┣ Context.pdb
 ┃ ┃ ┃ ┣ Entities.dll
 ┃ ┃ ┃ ┗ Entities.pdb
 ┣ obj
 ┃ ┣ Debug
 ┃ ┃ ┗ net6.0
 ┃ ┃ ┃ ┣ ref
 ┃ ┃ ┃ ┃ ┗ Context.dll
 ┃ ┃ ┃ ┣ .NETCoreApp,Version=v6.0.AssemblyAttributes.cs
 ┃ ┃ ┃ ┣ Context.AssemblyInfo.cs
 ┃ ┃ ┃ ┣ Context.AssemblyInfoInputs.cache
 ┃ ┃ ┃ ┣ Context.assets.cache
 ┃ ┃ ┃ ┣ Context.csproj.AssemblyReference.cache
 ┃ ┃ ┃ ┣ Context.csproj.CopyComplete
 ┃ ┃ ┃ ┣ Context.csproj.CoreCompileInputs.cache
 ┃ ┃ ┃ ┣ Context.csproj.FileListAbsolute.txt
 ┃ ┃ ┃ ┣ Context.dll
 ┃ ┃ ┃ ┣ Context.GeneratedMSBuildEditorConfig.editorconfig
 ┃ ┃ ┃ ┣ Context.GlobalUsings.g.cs
 ┃ ┃ ┃ ┗ Context.pdb
 ┃ ┣ Release
 ┃ ┃ ┗ net6.0
 ┃ ┃ ┃ ┣ ref
 ┃ ┃ ┃ ┃ ┗ Context.dll
 ┃ ┃ ┃ ┣ .NETCoreApp,Version=v6.0.AssemblyAttributes.cs
 ┃ ┃ ┃ ┣ Context.AssemblyInfo.cs
 ┃ ┃ ┃ ┣ Context.AssemblyInfoInputs.cache
 ┃ ┃ ┃ ┣ Context.assets.cache
 ┃ ┃ ┃ ┣ Context.csproj.AssemblyReference.cache
 ┃ ┃ ┃ ┣ Context.csproj.CopyComplete
 ┃ ┃ ┃ ┣ Context.csproj.CoreCompileInputs.cache
 ┃ ┃ ┃ ┣ Context.csproj.FileListAbsolute.txt
 ┃ ┃ ┃ ┣ Context.dll
 ┃ ┃ ┃ ┣ Context.GeneratedMSBuildEditorConfig.editorconfig
 ┃ ┃ ┃ ┣ Context.GlobalUsings.g.cs
 ┃ ┃ ┃ ┗ Context.pdb
 ┃ ┣ Context.csproj.nuget.dgspec.json
 ┃ ┣ Context.csproj.nuget.g.props
 ┃ ┣ Context.csproj.nuget.g.targets
 ┃ ┣ project.assets.json
 ┃ ┗ project.nuget.cache
 ┣ Cinema.cs
 ┗ Context.csproj
```

- WebApp
```
WebApp
 ┣ .vs
 ┃ ┣ WebApp
 ┃ ┃ ┗ v17
 ┃ ┃ ┃ ┗ .suo
 ┃ ┣ slnx.sqlite
 ┃ ┗ VSWorkspaceState.json
 ┣ .vscode
 ┃ ┗ launch.json
 ┣ bin
 ┃ ┣ Debug
 ┃ ┃ ┗ net6.0
 ┃ ┃ ┃ ┣ ref
 ┃ ┃ ┃ ┃ ┗ WebApp.dll
 ┃ ┃ ┃ ┣ runtimes
 ┃ ┃ ┃ ┃ ┣ alpine-x64
 ┃ ┃ ┃ ┃ ┃ ┗ native
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ libe_sqlite3.so
 ┃ ┃ ┃ ┃ ┣ linux-arm
 ┃ ┃ ┃ ┃ ┃ ┗ native
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ libe_sqlite3.so
 ┃ ┃ ┃ ┃ ┣ linux-arm64
 ┃ ┃ ┃ ┃ ┃ ┗ native
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ libe_sqlite3.so
 ┃ ┃ ┃ ┃ ┣ linux-armel
 ┃ ┃ ┃ ┃ ┃ ┗ native
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ libe_sqlite3.so
 ┃ ┃ ┃ ┃ ┣ linux-mips64
 ┃ ┃ ┃ ┃ ┃ ┗ native
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ libe_sqlite3.so
 ┃ ┃ ┃ ┃ ┣ linux-musl-x64
 ┃ ┃ ┃ ┃ ┃ ┗ native
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ libe_sqlite3.so
 ┃ ┃ ┃ ┃ ┣ linux-s390x
 ┃ ┃ ┃ ┃ ┃ ┗ native
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ libe_sqlite3.so
 ┃ ┃ ┃ ┃ ┣ linux-x64
 ┃ ┃ ┃ ┃ ┃ ┗ native
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ libe_sqlite3.so
 ┃ ┃ ┃ ┃ ┣ linux-x86
 ┃ ┃ ┃ ┃ ┃ ┗ native
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ libe_sqlite3.so
 ┃ ┃ ┃ ┃ ┣ osx-arm64
 ┃ ┃ ┃ ┃ ┃ ┗ native
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ libe_sqlite3.dylib
 ┃ ┃ ┃ ┃ ┣ osx-x64
 ┃ ┃ ┃ ┃ ┃ ┗ native
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ libe_sqlite3.dylib
 ┃ ┃ ┃ ┃ ┣ unix
 ┃ ┃ ┃ ┃ ┃ ┗ lib
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ netcoreapp2.0
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ System.Drawing.Common.dll
 ┃ ┃ ┃ ┃ ┣ win
 ┃ ┃ ┃ ┃ ┃ ┗ lib
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ netcoreapp2.0
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Win32.SystemEvents.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ System.Drawing.Common.dll
 ┃ ┃ ┃ ┃ ┣ win-arm
 ┃ ┃ ┃ ┃ ┃ ┗ native
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ e_sqlite3.dll
 ┃ ┃ ┃ ┃ ┣ win-arm64
 ┃ ┃ ┃ ┃ ┃ ┗ native
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ e_sqlite3.dll
 ┃ ┃ ┃ ┃ ┣ win-x64
 ┃ ┃ ┃ ┃ ┃ ┗ native
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ e_sqlite3.dll
 ┃ ┃ ┃ ┃ ┗ win-x86
 ┃ ┃ ┃ ┃ ┃ ┗ native
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ e_sqlite3.dll
 ┃ ┃ ┃ ┣ win10-x64
 ┃ ┃ ┃ ┃ ┣ publish
 ┃ ┃ ┃ ┃ ┃ ┣ wwwroot
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 12.png
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 15.png
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 18.png
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ PG.png
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ place.png
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ U.png
 ┃ ┃ ┃ ┃ ┃ ┣ Antlr3.Runtime.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-console-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-console-l1-2-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-datetime-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-debug-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-errorhandling-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-file-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-file-l1-2-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-file-l2-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-handle-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-heap-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-interlocked-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-libraryloader-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-localization-l1-2-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-memory-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-namedpipe-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-processenvironment-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-processthreads-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-processthreads-l1-1-1.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-profile-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-rtlsupport-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-string-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-synch-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-synch-l1-2-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-sysinfo-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-timezone-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-util-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-conio-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-convert-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-environment-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-filesystem-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-heap-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-locale-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-math-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-multibyte-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-private-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-process-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-runtime-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-stdio-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-string-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-time-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-utility-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ appsettings.Development.json
 ┃ ┃ ┃ ┃ ┃ ┣ appsettings.json
 ┃ ┃ ┃ ┃ ┃ ┣ aspnetcorev2_inprocess.dll
 ┃ ┃ ┃ ┃ ┃ ┣ BCrypt.Net-Next.dll
 ┃ ┃ ┃ ┃ ┃ ┣ clretwrc.dll
 ┃ ┃ ┃ ┃ ┃ ┣ clrjit.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Context.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Context.pdb
 ┃ ┃ ┃ ┃ ┃ ┣ coreclr.dll
 ┃ ┃ ┃ ┃ ┃ ┣ createdump.exe
 ┃ ┃ ┃ ┃ ┃ ┣ dbgshim.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Entities.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Entities.pdb
 ┃ ┃ ┃ ┃ ┃ ┣ e_sqlite3.dll
 ┃ ┃ ┃ ┃ ┃ ┣ hostfxr.dll
 ┃ ┃ ┃ ┃ ┃ ┣ hostpolicy.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Antiforgery.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Authentication.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Authentication.Cookies.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Authentication.Core.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Authentication.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Authentication.OAuth.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Authorization.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Authorization.Policy.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Components.Authorization.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Components.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Components.Forms.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Components.Server.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Components.Web.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Connections.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.CookiePolicy.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Cors.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Cryptography.Internal.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Cryptography.KeyDerivation.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.DataProtection.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.DataProtection.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.DataProtection.Extensions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Diagnostics.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Diagnostics.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Diagnostics.HealthChecks.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.HostFiltering.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Hosting.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Hosting.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Hosting.Server.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Html.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Http.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Http.Connections.Common.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Http.Connections.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Http.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Http.Extensions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Http.Features.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Http.Results.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.HttpLogging.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.HttpOverrides.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.HttpsPolicy.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Identity.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Localization.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Localization.Routing.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Metadata.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.ApiExplorer.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.Core.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.Cors.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.DataAnnotations.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.Formatters.Json.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.Formatters.Xml.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.Localization.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.Razor.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.RazorPages.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.TagHelpers.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.ViewFeatures.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Razor.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Razor.Runtime.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.ResponseCaching.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.ResponseCaching.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.ResponseCompression.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Rewrite.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Routing.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Routing.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Server.HttpSys.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Server.IIS.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Server.IISIntegration.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Server.Kestrel.Core.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Server.Kestrel.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Server.Kestrel.Transport.Quic.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Session.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.SignalR.Common.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.SignalR.Core.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.SignalR.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.SignalR.Protocols.Json.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.StaticFiles.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.WebSockets.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.WebUtilities.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.CSharp.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Data.Sqlite.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.DiaSymReader.Native.amd64.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.EntityFrameworkCore.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.EntityFrameworkCore.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.EntityFrameworkCore.Relational.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.EntityFrameworkCore.Sqlite.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Caching.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Caching.Memory.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.Binder.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.CommandLine.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.EnvironmentVariables.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.FileExtensions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.Ini.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.Json.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.KeyPerFile.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.UserSecrets.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.Xml.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.DependencyInjection.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.DependencyInjection.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.DependencyModel.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Diagnostics.HealthChecks.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Diagnostics.HealthChecks.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Features.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.FileProviders.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.FileProviders.Composite.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.FileProviders.Embedded.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.FileProviders.Physical.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.FileSystemGlobbing.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Hosting.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Hosting.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Http.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Identity.Core.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Identity.Stores.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Localization.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Localization.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Logging.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Logging.Configuration.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Logging.Console.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Logging.Debug.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Logging.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Logging.EventLog.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Logging.EventSource.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Logging.TraceSource.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.ObjectPool.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Options.ConfigurationExtensions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Options.DataAnnotations.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Options.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Primitives.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.WebEncoders.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.JSInterop.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Net.Http.Headers.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.VisualBasic.Core.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.VisualBasic.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Web.Infrastructure.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Win32.Primitives.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Win32.Registry.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Win32.SystemEvents.dll
 ┃ ┃ ┃ ┃ ┃ ┣ mscordaccore.dll
 ┃ ┃ ┃ ┃ ┃ ┣ mscordaccore_amd64_amd64_6.0.121.56705.dll
 ┃ ┃ ┃ ┃ ┃ ┣ mscordbi.dll
 ┃ ┃ ┃ ┃ ┃ ┣ mscorlib.dll
 ┃ ┃ ┃ ┃ ┃ ┣ mscorrc.dll
 ┃ ┃ ┃ ┃ ┃ ┣ msquic.dll
 ┃ ┃ ┃ ┃ ┃ ┣ netstandard.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Newtonsoft.Json.dll
 ┃ ┃ ┃ ┃ ┃ ┣ QRCoder.dll
 ┃ ┃ ┃ ┃ ┃ ┣ SQLitePCLRaw.batteries_v2.dll
 ┃ ┃ ┃ ┃ ┃ ┣ SQLitePCLRaw.core.dll
 ┃ ┃ ┃ ┃ ┃ ┣ SQLitePCLRaw.provider.e_sqlite3.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.AppContext.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Buffers.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Collections.Concurrent.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Collections.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Collections.Immutable.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Collections.NonGeneric.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Collections.Specialized.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.ComponentModel.Annotations.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.ComponentModel.DataAnnotations.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.ComponentModel.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.ComponentModel.EventBasedAsync.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.ComponentModel.Primitives.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.ComponentModel.TypeConverter.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Configuration.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Console.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Core.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Data.Common.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Data.DataSetExtensions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Data.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Diagnostics.Contracts.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Diagnostics.Debug.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Diagnostics.DiagnosticSource.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Diagnostics.EventLog.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Diagnostics.EventLog.Messages.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Diagnostics.FileVersionInfo.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Diagnostics.Process.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Diagnostics.StackTrace.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Diagnostics.TextWriterTraceListener.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Diagnostics.Tools.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Diagnostics.TraceSource.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Diagnostics.Tracing.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Drawing.Common.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Drawing.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Drawing.Primitives.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Dynamic.Runtime.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Formats.Asn1.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Globalization.Calendars.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Globalization.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Globalization.Extensions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.IO.Compression.Brotli.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.IO.Compression.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.IO.Compression.FileSystem.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.IO.Compression.Native.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.IO.Compression.ZipFile.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.IO.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.IO.FileSystem.AccessControl.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.IO.FileSystem.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.IO.FileSystem.DriveInfo.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.IO.FileSystem.Primitives.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.IO.FileSystem.Watcher.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.IO.IsolatedStorage.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.IO.MemoryMappedFiles.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.IO.Pipelines.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.IO.Pipes.AccessControl.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.IO.Pipes.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.IO.UnmanagedMemoryStream.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Linq.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Linq.Expressions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Linq.Parallel.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Linq.Queryable.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Memory.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.Http.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.Http.Json.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.HttpListener.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.Mail.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.NameResolution.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.NetworkInformation.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.Ping.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.Primitives.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.Quic.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.Requests.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.Security.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.ServicePoint.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.Sockets.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.WebClient.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.WebHeaderCollection.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.WebProxy.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.WebSockets.Client.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.WebSockets.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Numerics.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Numerics.Vectors.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.ObjectModel.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Private.CoreLib.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Private.DataContractSerialization.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Private.Uri.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Private.Xml.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Private.Xml.Linq.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Reflection.DispatchProxy.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Reflection.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Reflection.Emit.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Reflection.Emit.ILGeneration.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Reflection.Emit.Lightweight.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Reflection.Extensions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Reflection.Metadata.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Reflection.Primitives.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Reflection.TypeExtensions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Resources.Reader.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Resources.ResourceManager.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Resources.Writer.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Runtime.CompilerServices.Unsafe.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Runtime.CompilerServices.VisualC.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Runtime.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Runtime.Extensions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Runtime.Handles.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Runtime.InteropServices.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Runtime.InteropServices.RuntimeInformation.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Runtime.Intrinsics.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Runtime.Loader.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Runtime.Numerics.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Runtime.Serialization.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Runtime.Serialization.Formatters.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Runtime.Serialization.Json.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Runtime.Serialization.Primitives.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Runtime.Serialization.Xml.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Security.AccessControl.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Security.Claims.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Security.Cryptography.Algorithms.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Security.Cryptography.Cng.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Security.Cryptography.Csp.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Security.Cryptography.Encoding.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Security.Cryptography.OpenSsl.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Security.Cryptography.Pkcs.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Security.Cryptography.Primitives.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Security.Cryptography.X509Certificates.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Security.Cryptography.Xml.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Security.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Security.Permissions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Security.Principal.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Security.Principal.Windows.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Security.SecureString.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.ServiceModel.Web.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.ServiceProcess.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Text.Encoding.CodePages.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Text.Encoding.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Text.Encoding.Extensions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Text.Encodings.Web.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Text.Json.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Text.RegularExpressions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Threading.Channels.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Threading.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Threading.Overlapped.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Threading.Tasks.Dataflow.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Threading.Tasks.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Threading.Tasks.Extensions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Threading.Tasks.Parallel.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Threading.Thread.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Threading.ThreadPool.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Threading.Timer.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Transactions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Transactions.Local.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.ValueTuple.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Web.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Web.HttpUtility.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Web.Optimization.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Windows.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Xml.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Xml.Linq.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Xml.ReaderWriter.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Xml.Serialization.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Xml.XDocument.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Xml.XmlDocument.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Xml.XmlSerializer.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Xml.XPath.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Xml.XPath.XDocument.dll
 ┃ ┃ ┃ ┃ ┃ ┣ ucrtbase.dll
 ┃ ┃ ┃ ┃ ┃ ┣ web.config
 ┃ ┃ ┃ ┃ ┃ ┣ WebApp.deps.json
 ┃ ┃ ┃ ┃ ┃ ┣ WebApp.dll
 ┃ ┃ ┃ ┃ ┃ ┣ WebApp.exe
 ┃ ┃ ┃ ┃ ┃ ┣ WebApp.pdb
 ┃ ┃ ┃ ┃ ┃ ┣ WebApp.runtimeconfig.json
 ┃ ┃ ┃ ┃ ┃ ┣ WebGrease.dll
 ┃ ┃ ┃ ┃ ┃ ┗ WindowsBase.dll
 ┃ ┃ ┃ ┃ ┣ ref
 ┃ ┃ ┃ ┃ ┃ ┗ WebApp.dll
 ┃ ┃ ┃ ┃ ┣ Antlr3.Runtime.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-console-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-console-l1-2-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-datetime-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-debug-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-errorhandling-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-file-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-file-l1-2-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-file-l2-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-handle-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-heap-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-interlocked-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-libraryloader-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-localization-l1-2-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-memory-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-namedpipe-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-processenvironment-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-processthreads-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-processthreads-l1-1-1.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-profile-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-rtlsupport-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-string-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-synch-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-synch-l1-2-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-sysinfo-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-timezone-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-util-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-conio-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-convert-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-environment-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-filesystem-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-heap-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-locale-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-math-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-multibyte-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-private-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-process-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-runtime-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-stdio-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-string-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-time-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-utility-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ appsettings.Development.json
 ┃ ┃ ┃ ┃ ┣ appsettings.json
 ┃ ┃ ┃ ┃ ┣ aspnetcorev2_inprocess.dll
 ┃ ┃ ┃ ┃ ┣ BCrypt.Net-Next.dll
 ┃ ┃ ┃ ┃ ┣ clretwrc.dll
 ┃ ┃ ┃ ┃ ┣ clrjit.dll
 ┃ ┃ ┃ ┃ ┣ Context.dll
 ┃ ┃ ┃ ┃ ┣ Context.pdb
 ┃ ┃ ┃ ┃ ┣ coreclr.dll
 ┃ ┃ ┃ ┃ ┣ createdump.exe
 ┃ ┃ ┃ ┃ ┣ dbgshim.dll
 ┃ ┃ ┃ ┃ ┣ Entities.dll
 ┃ ┃ ┃ ┃ ┣ Entities.pdb
 ┃ ┃ ┃ ┃ ┣ e_sqlite3.dll
 ┃ ┃ ┃ ┃ ┣ hostfxr.dll
 ┃ ┃ ┃ ┃ ┣ hostpolicy.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Antiforgery.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Authentication.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Authentication.Cookies.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Authentication.Core.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Authentication.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Authentication.OAuth.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Authorization.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Authorization.Policy.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Components.Authorization.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Components.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Components.Forms.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Components.Server.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Components.Web.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Connections.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.CookiePolicy.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Cors.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Cryptography.Internal.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Cryptography.KeyDerivation.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.DataProtection.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.DataProtection.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.DataProtection.Extensions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Diagnostics.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Diagnostics.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Diagnostics.HealthChecks.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.HostFiltering.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Hosting.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Hosting.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Hosting.Server.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Html.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Http.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Http.Connections.Common.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Http.Connections.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Http.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Http.Extensions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Http.Features.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Http.Results.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.HttpLogging.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.HttpOverrides.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.HttpsPolicy.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Identity.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Localization.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Localization.Routing.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Metadata.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.ApiExplorer.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.Core.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.Cors.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.DataAnnotations.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.Formatters.Json.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.Formatters.Xml.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.Localization.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.Razor.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.RazorPages.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.TagHelpers.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.ViewFeatures.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Razor.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Razor.Runtime.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.ResponseCaching.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.ResponseCaching.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.ResponseCompression.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Rewrite.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Routing.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Routing.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Server.HttpSys.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Server.IIS.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Server.IISIntegration.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Server.Kestrel.Core.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Server.Kestrel.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Server.Kestrel.Transport.Quic.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Session.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.SignalR.Common.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.SignalR.Core.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.SignalR.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.SignalR.Protocols.Json.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.StaticFiles.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.WebSockets.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.WebUtilities.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.CSharp.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Data.Sqlite.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.DiaSymReader.Native.amd64.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.EntityFrameworkCore.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.EntityFrameworkCore.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.EntityFrameworkCore.Relational.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.EntityFrameworkCore.Sqlite.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Caching.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Caching.Memory.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.Binder.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.CommandLine.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.EnvironmentVariables.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.FileExtensions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.Ini.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.Json.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.KeyPerFile.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.UserSecrets.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.Xml.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.DependencyInjection.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.DependencyInjection.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.DependencyModel.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Diagnostics.HealthChecks.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Diagnostics.HealthChecks.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Features.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.FileProviders.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.FileProviders.Composite.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.FileProviders.Embedded.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.FileProviders.Physical.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.FileSystemGlobbing.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Hosting.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Hosting.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Http.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Identity.Core.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Identity.Stores.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Localization.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Localization.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Logging.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Logging.Configuration.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Logging.Console.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Logging.Debug.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Logging.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Logging.EventLog.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Logging.EventSource.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Logging.TraceSource.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.ObjectPool.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Options.ConfigurationExtensions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Options.DataAnnotations.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Options.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Primitives.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.WebEncoders.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.JSInterop.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Net.Http.Headers.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.VisualBasic.Core.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.VisualBasic.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Web.Infrastructure.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Win32.Primitives.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Win32.Registry.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Win32.SystemEvents.dll
 ┃ ┃ ┃ ┃ ┣ mscordaccore.dll
 ┃ ┃ ┃ ┃ ┣ mscordaccore_amd64_amd64_6.0.121.56705.dll
 ┃ ┃ ┃ ┃ ┣ mscordbi.dll
 ┃ ┃ ┃ ┃ ┣ mscorlib.dll
 ┃ ┃ ┃ ┃ ┣ mscorrc.dll
 ┃ ┃ ┃ ┃ ┣ msquic.dll
 ┃ ┃ ┃ ┃ ┣ netstandard.dll
 ┃ ┃ ┃ ┃ ┣ Newtonsoft.Json.dll
 ┃ ┃ ┃ ┃ ┣ QRCoder.dll
 ┃ ┃ ┃ ┃ ┣ SQLitePCLRaw.batteries_v2.dll
 ┃ ┃ ┃ ┃ ┣ SQLitePCLRaw.core.dll
 ┃ ┃ ┃ ┃ ┣ SQLitePCLRaw.provider.e_sqlite3.dll
 ┃ ┃ ┃ ┃ ┣ System.AppContext.dll
 ┃ ┃ ┃ ┃ ┣ System.Buffers.dll
 ┃ ┃ ┃ ┃ ┣ System.Collections.Concurrent.dll
 ┃ ┃ ┃ ┃ ┣ System.Collections.dll
 ┃ ┃ ┃ ┃ ┣ System.Collections.Immutable.dll
 ┃ ┃ ┃ ┃ ┣ System.Collections.NonGeneric.dll
 ┃ ┃ ┃ ┃ ┣ System.Collections.Specialized.dll
 ┃ ┃ ┃ ┃ ┣ System.ComponentModel.Annotations.dll
 ┃ ┃ ┃ ┃ ┣ System.ComponentModel.DataAnnotations.dll
 ┃ ┃ ┃ ┃ ┣ System.ComponentModel.dll
 ┃ ┃ ┃ ┃ ┣ System.ComponentModel.EventBasedAsync.dll
 ┃ ┃ ┃ ┃ ┣ System.ComponentModel.Primitives.dll
 ┃ ┃ ┃ ┃ ┣ System.ComponentModel.TypeConverter.dll
 ┃ ┃ ┃ ┃ ┣ System.Configuration.dll
 ┃ ┃ ┃ ┃ ┣ System.Console.dll
 ┃ ┃ ┃ ┃ ┣ System.Core.dll
 ┃ ┃ ┃ ┃ ┣ System.Data.Common.dll
 ┃ ┃ ┃ ┃ ┣ System.Data.DataSetExtensions.dll
 ┃ ┃ ┃ ┃ ┣ System.Data.dll
 ┃ ┃ ┃ ┃ ┣ System.Diagnostics.Contracts.dll
 ┃ ┃ ┃ ┃ ┣ System.Diagnostics.Debug.dll
 ┃ ┃ ┃ ┃ ┣ System.Diagnostics.DiagnosticSource.dll
 ┃ ┃ ┃ ┃ ┣ System.Diagnostics.EventLog.dll
 ┃ ┃ ┃ ┃ ┣ System.Diagnostics.EventLog.Messages.dll
 ┃ ┃ ┃ ┃ ┣ System.Diagnostics.FileVersionInfo.dll
 ┃ ┃ ┃ ┃ ┣ System.Diagnostics.Process.dll
 ┃ ┃ ┃ ┃ ┣ System.Diagnostics.StackTrace.dll
 ┃ ┃ ┃ ┃ ┣ System.Diagnostics.TextWriterTraceListener.dll
 ┃ ┃ ┃ ┃ ┣ System.Diagnostics.Tools.dll
 ┃ ┃ ┃ ┃ ┣ System.Diagnostics.TraceSource.dll
 ┃ ┃ ┃ ┃ ┣ System.Diagnostics.Tracing.dll
 ┃ ┃ ┃ ┃ ┣ System.dll
 ┃ ┃ ┃ ┃ ┣ System.Drawing.Common.dll
 ┃ ┃ ┃ ┃ ┣ System.Drawing.dll
 ┃ ┃ ┃ ┃ ┣ System.Drawing.Primitives.dll
 ┃ ┃ ┃ ┃ ┣ System.Dynamic.Runtime.dll
 ┃ ┃ ┃ ┃ ┣ System.Formats.Asn1.dll
 ┃ ┃ ┃ ┃ ┣ System.Globalization.Calendars.dll
 ┃ ┃ ┃ ┃ ┣ System.Globalization.dll
 ┃ ┃ ┃ ┃ ┣ System.Globalization.Extensions.dll
 ┃ ┃ ┃ ┃ ┣ System.IO.Compression.Brotli.dll
 ┃ ┃ ┃ ┃ ┣ System.IO.Compression.dll
 ┃ ┃ ┃ ┃ ┣ System.IO.Compression.FileSystem.dll
 ┃ ┃ ┃ ┃ ┣ System.IO.Compression.Native.dll
 ┃ ┃ ┃ ┃ ┣ System.IO.Compression.ZipFile.dll
 ┃ ┃ ┃ ┃ ┣ System.IO.dll
 ┃ ┃ ┃ ┃ ┣ System.IO.FileSystem.AccessControl.dll
 ┃ ┃ ┃ ┃ ┣ System.IO.FileSystem.dll
 ┃ ┃ ┃ ┃ ┣ System.IO.FileSystem.DriveInfo.dll
 ┃ ┃ ┃ ┃ ┣ System.IO.FileSystem.Primitives.dll
 ┃ ┃ ┃ ┃ ┣ System.IO.FileSystem.Watcher.dll
 ┃ ┃ ┃ ┃ ┣ System.IO.IsolatedStorage.dll
 ┃ ┃ ┃ ┃ ┣ System.IO.MemoryMappedFiles.dll
 ┃ ┃ ┃ ┃ ┣ System.IO.Pipelines.dll
 ┃ ┃ ┃ ┃ ┣ System.IO.Pipes.AccessControl.dll
 ┃ ┃ ┃ ┃ ┣ System.IO.Pipes.dll
 ┃ ┃ ┃ ┃ ┣ System.IO.UnmanagedMemoryStream.dll
 ┃ ┃ ┃ ┃ ┣ System.Linq.dll
 ┃ ┃ ┃ ┃ ┣ System.Linq.Expressions.dll
 ┃ ┃ ┃ ┃ ┣ System.Linq.Parallel.dll
 ┃ ┃ ┃ ┃ ┣ System.Linq.Queryable.dll
 ┃ ┃ ┃ ┃ ┣ System.Memory.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.Http.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.Http.Json.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.HttpListener.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.Mail.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.NameResolution.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.NetworkInformation.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.Ping.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.Primitives.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.Quic.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.Requests.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.Security.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.ServicePoint.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.Sockets.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.WebClient.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.WebHeaderCollection.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.WebProxy.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.WebSockets.Client.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.WebSockets.dll
 ┃ ┃ ┃ ┃ ┣ System.Numerics.dll
 ┃ ┃ ┃ ┃ ┣ System.Numerics.Vectors.dll
 ┃ ┃ ┃ ┃ ┣ System.ObjectModel.dll
 ┃ ┃ ┃ ┃ ┣ System.Private.CoreLib.dll
 ┃ ┃ ┃ ┃ ┣ System.Private.DataContractSerialization.dll
 ┃ ┃ ┃ ┃ ┣ System.Private.Uri.dll
 ┃ ┃ ┃ ┃ ┣ System.Private.Xml.dll
 ┃ ┃ ┃ ┃ ┣ System.Private.Xml.Linq.dll
 ┃ ┃ ┃ ┃ ┣ System.Reflection.DispatchProxy.dll
 ┃ ┃ ┃ ┃ ┣ System.Reflection.dll
 ┃ ┃ ┃ ┃ ┣ System.Reflection.Emit.dll
 ┃ ┃ ┃ ┃ ┣ System.Reflection.Emit.ILGeneration.dll
 ┃ ┃ ┃ ┃ ┣ System.Reflection.Emit.Lightweight.dll
 ┃ ┃ ┃ ┃ ┣ System.Reflection.Extensions.dll
 ┃ ┃ ┃ ┃ ┣ System.Reflection.Metadata.dll
 ┃ ┃ ┃ ┃ ┣ System.Reflection.Primitives.dll
 ┃ ┃ ┃ ┃ ┣ System.Reflection.TypeExtensions.dll
 ┃ ┃ ┃ ┃ ┣ System.Resources.Reader.dll
 ┃ ┃ ┃ ┃ ┣ System.Resources.ResourceManager.dll
 ┃ ┃ ┃ ┃ ┣ System.Resources.Writer.dll
 ┃ ┃ ┃ ┃ ┣ System.Runtime.CompilerServices.Unsafe.dll
 ┃ ┃ ┃ ┃ ┣ System.Runtime.CompilerServices.VisualC.dll
 ┃ ┃ ┃ ┃ ┣ System.Runtime.dll
 ┃ ┃ ┃ ┃ ┣ System.Runtime.Extensions.dll
 ┃ ┃ ┃ ┃ ┣ System.Runtime.Handles.dll
 ┃ ┃ ┃ ┃ ┣ System.Runtime.InteropServices.dll
 ┃ ┃ ┃ ┃ ┣ System.Runtime.InteropServices.RuntimeInformation.dll
 ┃ ┃ ┃ ┃ ┣ System.Runtime.Intrinsics.dll
 ┃ ┃ ┃ ┃ ┣ System.Runtime.Loader.dll
 ┃ ┃ ┃ ┃ ┣ System.Runtime.Numerics.dll
 ┃ ┃ ┃ ┃ ┣ System.Runtime.Serialization.dll
 ┃ ┃ ┃ ┃ ┣ System.Runtime.Serialization.Formatters.dll
 ┃ ┃ ┃ ┃ ┣ System.Runtime.Serialization.Json.dll
 ┃ ┃ ┃ ┃ ┣ System.Runtime.Serialization.Primitives.dll
 ┃ ┃ ┃ ┃ ┣ System.Runtime.Serialization.Xml.dll
 ┃ ┃ ┃ ┃ ┣ System.Security.AccessControl.dll
 ┃ ┃ ┃ ┃ ┣ System.Security.Claims.dll
 ┃ ┃ ┃ ┃ ┣ System.Security.Cryptography.Algorithms.dll
 ┃ ┃ ┃ ┃ ┣ System.Security.Cryptography.Cng.dll
 ┃ ┃ ┃ ┃ ┣ System.Security.Cryptography.Csp.dll
 ┃ ┃ ┃ ┃ ┣ System.Security.Cryptography.Encoding.dll
 ┃ ┃ ┃ ┃ ┣ System.Security.Cryptography.OpenSsl.dll
 ┃ ┃ ┃ ┃ ┣ System.Security.Cryptography.Pkcs.dll
 ┃ ┃ ┃ ┃ ┣ System.Security.Cryptography.Primitives.dll
 ┃ ┃ ┃ ┃ ┣ System.Security.Cryptography.X509Certificates.dll
 ┃ ┃ ┃ ┃ ┣ System.Security.Cryptography.Xml.dll
 ┃ ┃ ┃ ┃ ┣ System.Security.dll
 ┃ ┃ ┃ ┃ ┣ System.Security.Permissions.dll
 ┃ ┃ ┃ ┃ ┣ System.Security.Principal.dll
 ┃ ┃ ┃ ┃ ┣ System.Security.Principal.Windows.dll
 ┃ ┃ ┃ ┃ ┣ System.Security.SecureString.dll
 ┃ ┃ ┃ ┃ ┣ System.ServiceModel.Web.dll
 ┃ ┃ ┃ ┃ ┣ System.ServiceProcess.dll
 ┃ ┃ ┃ ┃ ┣ System.Text.Encoding.CodePages.dll
 ┃ ┃ ┃ ┃ ┣ System.Text.Encoding.dll
 ┃ ┃ ┃ ┃ ┣ System.Text.Encoding.Extensions.dll
 ┃ ┃ ┃ ┃ ┣ System.Text.Encodings.Web.dll
 ┃ ┃ ┃ ┃ ┣ System.Text.Json.dll
 ┃ ┃ ┃ ┃ ┣ System.Text.RegularExpressions.dll
 ┃ ┃ ┃ ┃ ┣ System.Threading.Channels.dll
 ┃ ┃ ┃ ┃ ┣ System.Threading.dll
 ┃ ┃ ┃ ┃ ┣ System.Threading.Overlapped.dll
 ┃ ┃ ┃ ┃ ┣ System.Threading.Tasks.Dataflow.dll
 ┃ ┃ ┃ ┃ ┣ System.Threading.Tasks.dll
 ┃ ┃ ┃ ┃ ┣ System.Threading.Tasks.Extensions.dll
 ┃ ┃ ┃ ┃ ┣ System.Threading.Tasks.Parallel.dll
 ┃ ┃ ┃ ┃ ┣ System.Threading.Thread.dll
 ┃ ┃ ┃ ┃ ┣ System.Threading.ThreadPool.dll
 ┃ ┃ ┃ ┃ ┣ System.Threading.Timer.dll
 ┃ ┃ ┃ ┃ ┣ System.Transactions.dll
 ┃ ┃ ┃ ┃ ┣ System.Transactions.Local.dll
 ┃ ┃ ┃ ┃ ┣ System.ValueTuple.dll
 ┃ ┃ ┃ ┃ ┣ System.Web.dll
 ┃ ┃ ┃ ┃ ┣ System.Web.HttpUtility.dll
 ┃ ┃ ┃ ┃ ┣ System.Web.Optimization.dll
 ┃ ┃ ┃ ┃ ┣ System.Windows.dll
 ┃ ┃ ┃ ┃ ┣ System.Xml.dll
 ┃ ┃ ┃ ┃ ┣ System.Xml.Linq.dll
 ┃ ┃ ┃ ┃ ┣ System.Xml.ReaderWriter.dll
 ┃ ┃ ┃ ┃ ┣ System.Xml.Serialization.dll
 ┃ ┃ ┃ ┃ ┣ System.Xml.XDocument.dll
 ┃ ┃ ┃ ┃ ┣ System.Xml.XmlDocument.dll
 ┃ ┃ ┃ ┃ ┣ System.Xml.XmlSerializer.dll
 ┃ ┃ ┃ ┃ ┣ System.Xml.XPath.dll
 ┃ ┃ ┃ ┃ ┣ System.Xml.XPath.XDocument.dll
 ┃ ┃ ┃ ┃ ┣ ucrtbase.dll
 ┃ ┃ ┃ ┃ ┣ WebApp.deps.json
 ┃ ┃ ┃ ┃ ┣ WebApp.dll
 ┃ ┃ ┃ ┃ ┣ WebApp.exe
 ┃ ┃ ┃ ┃ ┣ WebApp.pdb
 ┃ ┃ ┃ ┃ ┣ WebApp.runtimeconfig.json
 ┃ ┃ ┃ ┃ ┣ WebApp.staticwebassets.runtime.json
 ┃ ┃ ┃ ┃ ┣ WebGrease.dll
 ┃ ┃ ┃ ┃ ┗ WindowsBase.dll
 ┃ ┃ ┃ ┣ Antlr3.Runtime.dll
 ┃ ┃ ┃ ┣ appsettings.Development.json
 ┃ ┃ ┃ ┣ appsettings.json
 ┃ ┃ ┃ ┣ BCrypt.Net-Next.dll
 ┃ ┃ ┃ ┣ Context.dll
 ┃ ┃ ┃ ┣ Context.pdb
 ┃ ┃ ┃ ┣ Entities.dll
 ┃ ┃ ┃ ┣ Entities.pdb
 ┃ ┃ ┃ ┣ Microsoft.Data.Sqlite.dll
 ┃ ┃ ┃ ┣ Microsoft.EntityFrameworkCore.Abstractions.dll
 ┃ ┃ ┃ ┣ Microsoft.EntityFrameworkCore.dll
 ┃ ┃ ┃ ┣ Microsoft.EntityFrameworkCore.Relational.dll
 ┃ ┃ ┃ ┣ Microsoft.EntityFrameworkCore.Sqlite.dll
 ┃ ┃ ┃ ┣ Microsoft.Extensions.DependencyModel.dll
 ┃ ┃ ┃ ┣ Microsoft.Web.Infrastructure.dll
 ┃ ┃ ┃ ┣ Microsoft.Win32.SystemEvents.dll
 ┃ ┃ ┃ ┣ Newtonsoft.Json.dll
 ┃ ┃ ┃ ┣ QRCoder.dll
 ┃ ┃ ┃ ┣ SQLitePCLRaw.batteries_v2.dll
 ┃ ┃ ┃ ┣ SQLitePCLRaw.core.dll
 ┃ ┃ ┃ ┣ SQLitePCLRaw.provider.e_sqlite3.dll
 ┃ ┃ ┃ ┣ System.Drawing.Common.dll
 ┃ ┃ ┃ ┣ System.Security.Permissions.dll
 ┃ ┃ ┃ ┣ System.Web.Optimization.dll
 ┃ ┃ ┃ ┣ WebApp.deps.json
 ┃ ┃ ┃ ┣ WebApp.dll
 ┃ ┃ ┃ ┣ WebApp.exe
 ┃ ┃ ┃ ┣ WebApp.pdb
 ┃ ┃ ┃ ┣ WebApp.runtimeconfig.json
 ┃ ┃ ┃ ┣ WebApp.staticwebassets.runtime.json
 ┃ ┃ ┃ ┗ WebGrease.dll
 ┃ ┗ Release
 ┃ ┃ ┗ net6.0
 ┃ ┃ ┃ ┣ ref
 ┃ ┃ ┃ ┣ win10-x64
 ┃ ┃ ┃ ┃ ┣ publish
 ┃ ┃ ┃ ┃ ┃ ┣ wwwroot
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 12.png
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 15.png
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 18.png
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ PG.png
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ place.png
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ U.png
 ┃ ┃ ┃ ┃ ┃ ┣ Antlr3.Runtime.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-console-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-console-l1-2-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-datetime-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-debug-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-errorhandling-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-file-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-file-l1-2-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-file-l2-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-handle-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-heap-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-interlocked-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-libraryloader-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-localization-l1-2-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-memory-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-namedpipe-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-processenvironment-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-processthreads-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-processthreads-l1-1-1.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-profile-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-rtlsupport-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-string-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-synch-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-synch-l1-2-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-sysinfo-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-timezone-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-core-util-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-conio-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-convert-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-environment-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-filesystem-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-heap-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-locale-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-math-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-multibyte-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-private-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-process-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-runtime-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-stdio-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-string-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-time-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-utility-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┃ ┣ appsettings.Development.json
 ┃ ┃ ┃ ┃ ┃ ┣ appsettings.json
 ┃ ┃ ┃ ┃ ┃ ┣ aspnetcorev2_inprocess.dll
 ┃ ┃ ┃ ┃ ┃ ┣ BCrypt.Net-Next.dll
 ┃ ┃ ┃ ┃ ┃ ┣ clretwrc.dll
 ┃ ┃ ┃ ┃ ┃ ┣ clrjit.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Context.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Context.pdb
 ┃ ┃ ┃ ┃ ┃ ┣ coreclr.dll
 ┃ ┃ ┃ ┃ ┃ ┣ createdump.exe
 ┃ ┃ ┃ ┃ ┃ ┣ dbgshim.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Entities.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Entities.pdb
 ┃ ┃ ┃ ┃ ┃ ┣ e_sqlite3.dll
 ┃ ┃ ┃ ┃ ┃ ┣ hostfxr.dll
 ┃ ┃ ┃ ┃ ┃ ┣ hostpolicy.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Antiforgery.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Authentication.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Authentication.Cookies.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Authentication.Core.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Authentication.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Authentication.OAuth.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Authorization.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Authorization.Policy.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Components.Authorization.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Components.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Components.Forms.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Components.Server.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Components.Web.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Connections.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.CookiePolicy.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Cors.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Cryptography.Internal.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Cryptography.KeyDerivation.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.DataProtection.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.DataProtection.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.DataProtection.Extensions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Diagnostics.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Diagnostics.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Diagnostics.HealthChecks.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.HostFiltering.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Hosting.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Hosting.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Hosting.Server.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Html.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Http.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Http.Connections.Common.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Http.Connections.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Http.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Http.Extensions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Http.Features.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Http.Results.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.HttpLogging.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.HttpOverrides.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.HttpsPolicy.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Identity.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Localization.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Localization.Routing.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Metadata.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.ApiExplorer.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.Core.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.Cors.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.DataAnnotations.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.Formatters.Json.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.Formatters.Xml.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.Localization.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.Razor.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.RazorPages.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.TagHelpers.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.ViewFeatures.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Razor.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Razor.Runtime.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.ResponseCaching.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.ResponseCaching.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.ResponseCompression.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Rewrite.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Routing.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Routing.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Server.HttpSys.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Server.IIS.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Server.IISIntegration.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Server.Kestrel.Core.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Server.Kestrel.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Server.Kestrel.Transport.Quic.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Session.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.SignalR.Common.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.SignalR.Core.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.SignalR.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.SignalR.Protocols.Json.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.StaticFiles.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.WebSockets.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.WebUtilities.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.CSharp.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Data.Sqlite.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.DiaSymReader.Native.amd64.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.EntityFrameworkCore.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.EntityFrameworkCore.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.EntityFrameworkCore.Relational.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.EntityFrameworkCore.Sqlite.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Caching.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Caching.Memory.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.Binder.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.CommandLine.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.EnvironmentVariables.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.FileExtensions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.Ini.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.Json.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.KeyPerFile.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.UserSecrets.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.Xml.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.DependencyInjection.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.DependencyInjection.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.DependencyModel.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Diagnostics.HealthChecks.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Diagnostics.HealthChecks.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Features.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.FileProviders.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.FileProviders.Composite.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.FileProviders.Embedded.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.FileProviders.Physical.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.FileSystemGlobbing.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Hosting.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Hosting.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Http.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Identity.Core.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Identity.Stores.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Localization.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Localization.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Logging.Abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Logging.Configuration.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Logging.Console.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Logging.Debug.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Logging.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Logging.EventLog.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Logging.EventSource.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Logging.TraceSource.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.ObjectPool.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Options.ConfigurationExtensions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Options.DataAnnotations.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Options.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Primitives.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.WebEncoders.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.JSInterop.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Net.Http.Headers.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.VisualBasic.Core.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.VisualBasic.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Web.Infrastructure.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Win32.Primitives.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Win32.Registry.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Microsoft.Win32.SystemEvents.dll
 ┃ ┃ ┃ ┃ ┃ ┣ mscordaccore.dll
 ┃ ┃ ┃ ┃ ┃ ┣ mscordaccore_amd64_amd64_6.0.121.56705.dll
 ┃ ┃ ┃ ┃ ┃ ┣ mscordbi.dll
 ┃ ┃ ┃ ┃ ┃ ┣ mscorlib.dll
 ┃ ┃ ┃ ┃ ┃ ┣ mscorrc.dll
 ┃ ┃ ┃ ┃ ┃ ┣ msquic.dll
 ┃ ┃ ┃ ┃ ┃ ┣ netstandard.dll
 ┃ ┃ ┃ ┃ ┃ ┣ Newtonsoft.Json.dll
 ┃ ┃ ┃ ┃ ┃ ┣ QRCoder.dll
 ┃ ┃ ┃ ┃ ┃ ┣ SQLitePCLRaw.batteries_v2.dll
 ┃ ┃ ┃ ┃ ┃ ┣ SQLitePCLRaw.core.dll
 ┃ ┃ ┃ ┃ ┃ ┣ SQLitePCLRaw.provider.e_sqlite3.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.AppContext.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Buffers.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Collections.Concurrent.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Collections.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Collections.Immutable.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Collections.NonGeneric.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Collections.Specialized.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.ComponentModel.Annotations.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.ComponentModel.DataAnnotations.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.ComponentModel.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.ComponentModel.EventBasedAsync.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.ComponentModel.Primitives.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.ComponentModel.TypeConverter.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Configuration.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Console.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Core.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Data.Common.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Data.DataSetExtensions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Data.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Diagnostics.Contracts.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Diagnostics.Debug.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Diagnostics.DiagnosticSource.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Diagnostics.EventLog.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Diagnostics.EventLog.Messages.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Diagnostics.FileVersionInfo.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Diagnostics.Process.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Diagnostics.StackTrace.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Diagnostics.TextWriterTraceListener.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Diagnostics.Tools.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Diagnostics.TraceSource.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Diagnostics.Tracing.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Drawing.Common.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Drawing.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Drawing.Primitives.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Dynamic.Runtime.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Formats.Asn1.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Globalization.Calendars.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Globalization.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Globalization.Extensions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.IO.Compression.Brotli.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.IO.Compression.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.IO.Compression.FileSystem.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.IO.Compression.Native.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.IO.Compression.ZipFile.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.IO.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.IO.FileSystem.AccessControl.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.IO.FileSystem.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.IO.FileSystem.DriveInfo.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.IO.FileSystem.Primitives.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.IO.FileSystem.Watcher.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.IO.IsolatedStorage.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.IO.MemoryMappedFiles.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.IO.Pipelines.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.IO.Pipes.AccessControl.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.IO.Pipes.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.IO.UnmanagedMemoryStream.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Linq.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Linq.Expressions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Linq.Parallel.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Linq.Queryable.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Memory.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.Http.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.Http.Json.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.HttpListener.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.Mail.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.NameResolution.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.NetworkInformation.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.Ping.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.Primitives.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.Quic.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.Requests.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.Security.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.ServicePoint.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.Sockets.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.WebClient.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.WebHeaderCollection.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.WebProxy.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.WebSockets.Client.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Net.WebSockets.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Numerics.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Numerics.Vectors.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.ObjectModel.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Private.CoreLib.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Private.DataContractSerialization.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Private.Uri.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Private.Xml.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Private.Xml.Linq.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Reflection.DispatchProxy.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Reflection.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Reflection.Emit.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Reflection.Emit.ILGeneration.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Reflection.Emit.Lightweight.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Reflection.Extensions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Reflection.Metadata.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Reflection.Primitives.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Reflection.TypeExtensions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Resources.Reader.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Resources.ResourceManager.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Resources.Writer.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Runtime.CompilerServices.Unsafe.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Runtime.CompilerServices.VisualC.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Runtime.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Runtime.Extensions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Runtime.Handles.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Runtime.InteropServices.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Runtime.InteropServices.RuntimeInformation.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Runtime.Intrinsics.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Runtime.Loader.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Runtime.Numerics.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Runtime.Serialization.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Runtime.Serialization.Formatters.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Runtime.Serialization.Json.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Runtime.Serialization.Primitives.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Runtime.Serialization.Xml.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Security.AccessControl.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Security.Claims.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Security.Cryptography.Algorithms.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Security.Cryptography.Cng.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Security.Cryptography.Csp.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Security.Cryptography.Encoding.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Security.Cryptography.OpenSsl.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Security.Cryptography.Pkcs.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Security.Cryptography.Primitives.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Security.Cryptography.X509Certificates.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Security.Cryptography.Xml.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Security.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Security.Permissions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Security.Principal.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Security.Principal.Windows.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Security.SecureString.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.ServiceModel.Web.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.ServiceProcess.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Text.Encoding.CodePages.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Text.Encoding.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Text.Encoding.Extensions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Text.Encodings.Web.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Text.Json.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Text.RegularExpressions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Threading.Channels.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Threading.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Threading.Overlapped.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Threading.Tasks.Dataflow.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Threading.Tasks.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Threading.Tasks.Extensions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Threading.Tasks.Parallel.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Threading.Thread.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Threading.ThreadPool.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Threading.Timer.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Transactions.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Transactions.Local.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.ValueTuple.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Web.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Web.HttpUtility.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Web.Optimization.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Windows.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Xml.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Xml.Linq.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Xml.ReaderWriter.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Xml.Serialization.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Xml.XDocument.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Xml.XmlDocument.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Xml.XmlSerializer.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Xml.XPath.dll
 ┃ ┃ ┃ ┃ ┃ ┣ System.Xml.XPath.XDocument.dll
 ┃ ┃ ┃ ┃ ┃ ┣ ucrtbase.dll
 ┃ ┃ ┃ ┃ ┃ ┣ web.config
 ┃ ┃ ┃ ┃ ┃ ┣ WebApp.deps.json
 ┃ ┃ ┃ ┃ ┃ ┣ WebApp.dll
 ┃ ┃ ┃ ┃ ┃ ┣ WebApp.exe
 ┃ ┃ ┃ ┃ ┃ ┣ WebApp.pdb
 ┃ ┃ ┃ ┃ ┃ ┣ WebApp.runtimeconfig.json
 ┃ ┃ ┃ ┃ ┃ ┣ WebGrease.dll
 ┃ ┃ ┃ ┃ ┃ ┗ WindowsBase.dll
 ┃ ┃ ┃ ┃ ┣ ref
 ┃ ┃ ┃ ┃ ┃ ┗ WebApp.dll
 ┃ ┃ ┃ ┃ ┣ Antlr3.Runtime.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-console-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-console-l1-2-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-datetime-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-debug-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-errorhandling-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-file-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-file-l1-2-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-file-l2-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-handle-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-heap-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-interlocked-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-libraryloader-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-localization-l1-2-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-memory-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-namedpipe-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-processenvironment-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-processthreads-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-processthreads-l1-1-1.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-profile-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-rtlsupport-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-string-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-synch-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-synch-l1-2-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-sysinfo-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-timezone-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-core-util-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-conio-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-convert-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-environment-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-filesystem-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-heap-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-locale-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-math-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-multibyte-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-private-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-process-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-runtime-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-stdio-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-string-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-time-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ api-ms-win-crt-utility-l1-1-0.dll
 ┃ ┃ ┃ ┃ ┣ appsettings.Development.json
 ┃ ┃ ┃ ┃ ┣ appsettings.json
 ┃ ┃ ┃ ┃ ┣ aspnetcorev2_inprocess.dll
 ┃ ┃ ┃ ┃ ┣ BCrypt.Net-Next.dll
 ┃ ┃ ┃ ┃ ┣ clretwrc.dll
 ┃ ┃ ┃ ┃ ┣ clrjit.dll
 ┃ ┃ ┃ ┃ ┣ Context.dll
 ┃ ┃ ┃ ┃ ┣ Context.pdb
 ┃ ┃ ┃ ┃ ┣ coreclr.dll
 ┃ ┃ ┃ ┃ ┣ createdump.exe
 ┃ ┃ ┃ ┃ ┣ dbgshim.dll
 ┃ ┃ ┃ ┃ ┣ Entities.dll
 ┃ ┃ ┃ ┃ ┣ Entities.pdb
 ┃ ┃ ┃ ┃ ┣ e_sqlite3.dll
 ┃ ┃ ┃ ┃ ┣ hostfxr.dll
 ┃ ┃ ┃ ┃ ┣ hostpolicy.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Antiforgery.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Authentication.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Authentication.Cookies.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Authentication.Core.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Authentication.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Authentication.OAuth.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Authorization.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Authorization.Policy.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Components.Authorization.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Components.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Components.Forms.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Components.Server.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Components.Web.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Connections.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.CookiePolicy.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Cors.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Cryptography.Internal.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Cryptography.KeyDerivation.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.DataProtection.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.DataProtection.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.DataProtection.Extensions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Diagnostics.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Diagnostics.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Diagnostics.HealthChecks.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.HostFiltering.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Hosting.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Hosting.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Hosting.Server.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Html.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Http.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Http.Connections.Common.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Http.Connections.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Http.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Http.Extensions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Http.Features.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Http.Results.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.HttpLogging.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.HttpOverrides.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.HttpsPolicy.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Identity.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Localization.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Localization.Routing.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Metadata.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.ApiExplorer.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.Core.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.Cors.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.DataAnnotations.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.Formatters.Json.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.Formatters.Xml.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.Localization.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.Razor.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.RazorPages.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.TagHelpers.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Mvc.ViewFeatures.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Razor.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Razor.Runtime.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.ResponseCaching.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.ResponseCaching.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.ResponseCompression.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Rewrite.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Routing.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Routing.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Server.HttpSys.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Server.IIS.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Server.IISIntegration.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Server.Kestrel.Core.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Server.Kestrel.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Server.Kestrel.Transport.Quic.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.Session.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.SignalR.Common.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.SignalR.Core.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.SignalR.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.SignalR.Protocols.Json.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.StaticFiles.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.WebSockets.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.AspNetCore.WebUtilities.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.CSharp.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Data.Sqlite.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.DiaSymReader.Native.amd64.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.EntityFrameworkCore.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.EntityFrameworkCore.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.EntityFrameworkCore.Relational.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.EntityFrameworkCore.Sqlite.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Caching.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Caching.Memory.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.Binder.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.CommandLine.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.EnvironmentVariables.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.FileExtensions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.Ini.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.Json.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.KeyPerFile.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.UserSecrets.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Configuration.Xml.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.DependencyInjection.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.DependencyInjection.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.DependencyModel.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Diagnostics.HealthChecks.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Diagnostics.HealthChecks.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Features.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.FileProviders.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.FileProviders.Composite.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.FileProviders.Embedded.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.FileProviders.Physical.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.FileSystemGlobbing.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Hosting.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Hosting.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Http.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Identity.Core.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Identity.Stores.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Localization.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Localization.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Logging.Abstractions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Logging.Configuration.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Logging.Console.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Logging.Debug.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Logging.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Logging.EventLog.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Logging.EventSource.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Logging.TraceSource.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.ObjectPool.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Options.ConfigurationExtensions.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Options.DataAnnotations.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Options.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.Primitives.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Extensions.WebEncoders.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.JSInterop.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Net.Http.Headers.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.VisualBasic.Core.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.VisualBasic.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Web.Infrastructure.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Win32.Primitives.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Win32.Registry.dll
 ┃ ┃ ┃ ┃ ┣ Microsoft.Win32.SystemEvents.dll
 ┃ ┃ ┃ ┃ ┣ mscordaccore.dll
 ┃ ┃ ┃ ┃ ┣ mscordaccore_amd64_amd64_6.0.121.56705.dll
 ┃ ┃ ┃ ┃ ┣ mscordbi.dll
 ┃ ┃ ┃ ┃ ┣ mscorlib.dll
 ┃ ┃ ┃ ┃ ┣ mscorrc.dll
 ┃ ┃ ┃ ┃ ┣ msquic.dll
 ┃ ┃ ┃ ┃ ┣ netstandard.dll
 ┃ ┃ ┃ ┃ ┣ Newtonsoft.Json.dll
 ┃ ┃ ┃ ┃ ┣ QRCoder.dll
 ┃ ┃ ┃ ┃ ┣ SQLitePCLRaw.batteries_v2.dll
 ┃ ┃ ┃ ┃ ┣ SQLitePCLRaw.core.dll
 ┃ ┃ ┃ ┃ ┣ SQLitePCLRaw.provider.e_sqlite3.dll
 ┃ ┃ ┃ ┃ ┣ System.AppContext.dll
 ┃ ┃ ┃ ┃ ┣ System.Buffers.dll
 ┃ ┃ ┃ ┃ ┣ System.Collections.Concurrent.dll
 ┃ ┃ ┃ ┃ ┣ System.Collections.dll
 ┃ ┃ ┃ ┃ ┣ System.Collections.Immutable.dll
 ┃ ┃ ┃ ┃ ┣ System.Collections.NonGeneric.dll
 ┃ ┃ ┃ ┃ ┣ System.Collections.Specialized.dll
 ┃ ┃ ┃ ┃ ┣ System.ComponentModel.Annotations.dll
 ┃ ┃ ┃ ┃ ┣ System.ComponentModel.DataAnnotations.dll
 ┃ ┃ ┃ ┃ ┣ System.ComponentModel.dll
 ┃ ┃ ┃ ┃ ┣ System.ComponentModel.EventBasedAsync.dll
 ┃ ┃ ┃ ┃ ┣ System.ComponentModel.Primitives.dll
 ┃ ┃ ┃ ┃ ┣ System.ComponentModel.TypeConverter.dll
 ┃ ┃ ┃ ┃ ┣ System.Configuration.dll
 ┃ ┃ ┃ ┃ ┣ System.Console.dll
 ┃ ┃ ┃ ┃ ┣ System.Core.dll
 ┃ ┃ ┃ ┃ ┣ System.Data.Common.dll
 ┃ ┃ ┃ ┃ ┣ System.Data.DataSetExtensions.dll
 ┃ ┃ ┃ ┃ ┣ System.Data.dll
 ┃ ┃ ┃ ┃ ┣ System.Diagnostics.Contracts.dll
 ┃ ┃ ┃ ┃ ┣ System.Diagnostics.Debug.dll
 ┃ ┃ ┃ ┃ ┣ System.Diagnostics.DiagnosticSource.dll
 ┃ ┃ ┃ ┃ ┣ System.Diagnostics.EventLog.dll
 ┃ ┃ ┃ ┃ ┣ System.Diagnostics.EventLog.Messages.dll
 ┃ ┃ ┃ ┃ ┣ System.Diagnostics.FileVersionInfo.dll
 ┃ ┃ ┃ ┃ ┣ System.Diagnostics.Process.dll
 ┃ ┃ ┃ ┃ ┣ System.Diagnostics.StackTrace.dll
 ┃ ┃ ┃ ┃ ┣ System.Diagnostics.TextWriterTraceListener.dll
 ┃ ┃ ┃ ┃ ┣ System.Diagnostics.Tools.dll
 ┃ ┃ ┃ ┃ ┣ System.Diagnostics.TraceSource.dll
 ┃ ┃ ┃ ┃ ┣ System.Diagnostics.Tracing.dll
 ┃ ┃ ┃ ┃ ┣ System.dll
 ┃ ┃ ┃ ┃ ┣ System.Drawing.Common.dll
 ┃ ┃ ┃ ┃ ┣ System.Drawing.dll
 ┃ ┃ ┃ ┃ ┣ System.Drawing.Primitives.dll
 ┃ ┃ ┃ ┃ ┣ System.Dynamic.Runtime.dll
 ┃ ┃ ┃ ┃ ┣ System.Formats.Asn1.dll
 ┃ ┃ ┃ ┃ ┣ System.Globalization.Calendars.dll
 ┃ ┃ ┃ ┃ ┣ System.Globalization.dll
 ┃ ┃ ┃ ┃ ┣ System.Globalization.Extensions.dll
 ┃ ┃ ┃ ┃ ┣ System.IO.Compression.Brotli.dll
 ┃ ┃ ┃ ┃ ┣ System.IO.Compression.dll
 ┃ ┃ ┃ ┃ ┣ System.IO.Compression.FileSystem.dll
 ┃ ┃ ┃ ┃ ┣ System.IO.Compression.Native.dll
 ┃ ┃ ┃ ┃ ┣ System.IO.Compression.ZipFile.dll
 ┃ ┃ ┃ ┃ ┣ System.IO.dll
 ┃ ┃ ┃ ┃ ┣ System.IO.FileSystem.AccessControl.dll
 ┃ ┃ ┃ ┃ ┣ System.IO.FileSystem.dll
 ┃ ┃ ┃ ┃ ┣ System.IO.FileSystem.DriveInfo.dll
 ┃ ┃ ┃ ┃ ┣ System.IO.FileSystem.Primitives.dll
 ┃ ┃ ┃ ┃ ┣ System.IO.FileSystem.Watcher.dll
 ┃ ┃ ┃ ┃ ┣ System.IO.IsolatedStorage.dll
 ┃ ┃ ┃ ┃ ┣ System.IO.MemoryMappedFiles.dll
 ┃ ┃ ┃ ┃ ┣ System.IO.Pipelines.dll
 ┃ ┃ ┃ ┃ ┣ System.IO.Pipes.AccessControl.dll
 ┃ ┃ ┃ ┃ ┣ System.IO.Pipes.dll
 ┃ ┃ ┃ ┃ ┣ System.IO.UnmanagedMemoryStream.dll
 ┃ ┃ ┃ ┃ ┣ System.Linq.dll
 ┃ ┃ ┃ ┃ ┣ System.Linq.Expressions.dll
 ┃ ┃ ┃ ┃ ┣ System.Linq.Parallel.dll
 ┃ ┃ ┃ ┃ ┣ System.Linq.Queryable.dll
 ┃ ┃ ┃ ┃ ┣ System.Memory.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.Http.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.Http.Json.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.HttpListener.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.Mail.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.NameResolution.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.NetworkInformation.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.Ping.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.Primitives.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.Quic.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.Requests.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.Security.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.ServicePoint.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.Sockets.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.WebClient.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.WebHeaderCollection.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.WebProxy.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.WebSockets.Client.dll
 ┃ ┃ ┃ ┃ ┣ System.Net.WebSockets.dll
 ┃ ┃ ┃ ┃ ┣ System.Numerics.dll
 ┃ ┃ ┃ ┃ ┣ System.Numerics.Vectors.dll
 ┃ ┃ ┃ ┃ ┣ System.ObjectModel.dll
 ┃ ┃ ┃ ┃ ┣ System.Private.CoreLib.dll
 ┃ ┃ ┃ ┃ ┣ System.Private.DataContractSerialization.dll
 ┃ ┃ ┃ ┃ ┣ System.Private.Uri.dll
 ┃ ┃ ┃ ┃ ┣ System.Private.Xml.dll
 ┃ ┃ ┃ ┃ ┣ System.Private.Xml.Linq.dll
 ┃ ┃ ┃ ┃ ┣ System.Reflection.DispatchProxy.dll
 ┃ ┃ ┃ ┃ ┣ System.Reflection.dll
 ┃ ┃ ┃ ┃ ┣ System.Reflection.Emit.dll
 ┃ ┃ ┃ ┃ ┣ System.Reflection.Emit.ILGeneration.dll
 ┃ ┃ ┃ ┃ ┣ System.Reflection.Emit.Lightweight.dll
 ┃ ┃ ┃ ┃ ┣ System.Reflection.Extensions.dll
 ┃ ┃ ┃ ┃ ┣ System.Reflection.Metadata.dll
 ┃ ┃ ┃ ┃ ┣ System.Reflection.Primitives.dll
 ┃ ┃ ┃ ┃ ┣ System.Reflection.TypeExtensions.dll
 ┃ ┃ ┃ ┃ ┣ System.Resources.Reader.dll
 ┃ ┃ ┃ ┃ ┣ System.Resources.ResourceManager.dll
 ┃ ┃ ┃ ┃ ┣ System.Resources.Writer.dll
 ┃ ┃ ┃ ┃ ┣ System.Runtime.CompilerServices.Unsafe.dll
 ┃ ┃ ┃ ┃ ┣ System.Runtime.CompilerServices.VisualC.dll
 ┃ ┃ ┃ ┃ ┣ System.Runtime.dll
 ┃ ┃ ┃ ┃ ┣ System.Runtime.Extensions.dll
 ┃ ┃ ┃ ┃ ┣ System.Runtime.Handles.dll
 ┃ ┃ ┃ ┃ ┣ System.Runtime.InteropServices.dll
 ┃ ┃ ┃ ┃ ┣ System.Runtime.InteropServices.RuntimeInformation.dll
 ┃ ┃ ┃ ┃ ┣ System.Runtime.Intrinsics.dll
 ┃ ┃ ┃ ┃ ┣ System.Runtime.Loader.dll
 ┃ ┃ ┃ ┃ ┣ System.Runtime.Numerics.dll
 ┃ ┃ ┃ ┃ ┣ System.Runtime.Serialization.dll
 ┃ ┃ ┃ ┃ ┣ System.Runtime.Serialization.Formatters.dll
 ┃ ┃ ┃ ┃ ┣ System.Runtime.Serialization.Json.dll
 ┃ ┃ ┃ ┃ ┣ System.Runtime.Serialization.Primitives.dll
 ┃ ┃ ┃ ┃ ┣ System.Runtime.Serialization.Xml.dll
 ┃ ┃ ┃ ┃ ┣ System.Security.AccessControl.dll
 ┃ ┃ ┃ ┃ ┣ System.Security.Claims.dll
 ┃ ┃ ┃ ┃ ┣ System.Security.Cryptography.Algorithms.dll
 ┃ ┃ ┃ ┃ ┣ System.Security.Cryptography.Cng.dll
 ┃ ┃ ┃ ┃ ┣ System.Security.Cryptography.Csp.dll
 ┃ ┃ ┃ ┃ ┣ System.Security.Cryptography.Encoding.dll
 ┃ ┃ ┃ ┃ ┣ System.Security.Cryptography.OpenSsl.dll
 ┃ ┃ ┃ ┃ ┣ System.Security.Cryptography.Pkcs.dll
 ┃ ┃ ┃ ┃ ┣ System.Security.Cryptography.Primitives.dll
 ┃ ┃ ┃ ┃ ┣ System.Security.Cryptography.X509Certificates.dll
 ┃ ┃ ┃ ┃ ┣ System.Security.Cryptography.Xml.dll
 ┃ ┃ ┃ ┃ ┣ System.Security.dll
 ┃ ┃ ┃ ┃ ┣ System.Security.Permissions.dll
 ┃ ┃ ┃ ┃ ┣ System.Security.Principal.dll
 ┃ ┃ ┃ ┃ ┣ System.Security.Principal.Windows.dll
 ┃ ┃ ┃ ┃ ┣ System.Security.SecureString.dll
 ┃ ┃ ┃ ┃ ┣ System.ServiceModel.Web.dll
 ┃ ┃ ┃ ┃ ┣ System.ServiceProcess.dll
 ┃ ┃ ┃ ┃ ┣ System.Text.Encoding.CodePages.dll
 ┃ ┃ ┃ ┃ ┣ System.Text.Encoding.dll
 ┃ ┃ ┃ ┃ ┣ System.Text.Encoding.Extensions.dll
 ┃ ┃ ┃ ┃ ┣ System.Text.Encodings.Web.dll
 ┃ ┃ ┃ ┃ ┣ System.Text.Json.dll
 ┃ ┃ ┃ ┃ ┣ System.Text.RegularExpressions.dll
 ┃ ┃ ┃ ┃ ┣ System.Threading.Channels.dll
 ┃ ┃ ┃ ┃ ┣ System.Threading.dll
 ┃ ┃ ┃ ┃ ┣ System.Threading.Overlapped.dll
 ┃ ┃ ┃ ┃ ┣ System.Threading.Tasks.Dataflow.dll
 ┃ ┃ ┃ ┃ ┣ System.Threading.Tasks.dll
 ┃ ┃ ┃ ┃ ┣ System.Threading.Tasks.Extensions.dll
 ┃ ┃ ┃ ┃ ┣ System.Threading.Tasks.Parallel.dll
 ┃ ┃ ┃ ┃ ┣ System.Threading.Thread.dll
 ┃ ┃ ┃ ┃ ┣ System.Threading.ThreadPool.dll
 ┃ ┃ ┃ ┃ ┣ System.Threading.Timer.dll
 ┃ ┃ ┃ ┃ ┣ System.Transactions.dll
 ┃ ┃ ┃ ┃ ┣ System.Transactions.Local.dll
 ┃ ┃ ┃ ┃ ┣ System.ValueTuple.dll
 ┃ ┃ ┃ ┃ ┣ System.Web.dll
 ┃ ┃ ┃ ┃ ┣ System.Web.HttpUtility.dll
 ┃ ┃ ┃ ┃ ┣ System.Web.Optimization.dll
 ┃ ┃ ┃ ┃ ┣ System.Windows.dll
 ┃ ┃ ┃ ┃ ┣ System.Xml.dll
 ┃ ┃ ┃ ┃ ┣ System.Xml.Linq.dll
 ┃ ┃ ┃ ┃ ┣ System.Xml.ReaderWriter.dll
 ┃ ┃ ┃ ┃ ┣ System.Xml.Serialization.dll
 ┃ ┃ ┃ ┃ ┣ System.Xml.XDocument.dll
 ┃ ┃ ┃ ┃ ┣ System.Xml.XmlDocument.dll
 ┃ ┃ ┃ ┃ ┣ System.Xml.XmlSerializer.dll
 ┃ ┃ ┃ ┃ ┣ System.Xml.XPath.dll
 ┃ ┃ ┃ ┃ ┣ System.Xml.XPath.XDocument.dll
 ┃ ┃ ┃ ┃ ┣ ucrtbase.dll
 ┃ ┃ ┃ ┃ ┣ WebApp.deps.json
 ┃ ┃ ┃ ┃ ┣ WebApp.dll
 ┃ ┃ ┃ ┃ ┣ WebApp.exe
 ┃ ┃ ┃ ┃ ┣ WebApp.pdb
 ┃ ┃ ┃ ┃ ┣ WebApp.runtimeconfig.json
 ┃ ┃ ┃ ┃ ┣ WebApp.staticwebassets.runtime.json
 ┃ ┃ ┃ ┃ ┣ WebGrease.dll
 ┃ ┃ ┃ ┃ ┗ WindowsBase.dll
 ┃ ┃ ┃ ┗ Cinema.db
 ┣ DatabaseDisplayTestFiles
 ┃ ┣ Account.cshtml
 ┃ ┣ Account.cshtml.cs
 ┃ ┣ Actor.cshtml
 ┃ ┣ Actor.cshtml.cs
 ┃ ┣ AgeRating.cshtml
 ┃ ┣ AgeRating.cshtml.cs
 ┃ ┣ Booking.cshtml
 ┃ ┣ Booking.cshtml.cs
 ┃ ┣ Building.cshtml
 ┃ ┣ Building.cshtml.cs
 ┃ ┣ Genre.cshtml
 ┃ ┣ Genre.cshtml.cs
 ┃ ┣ Movie.cshtml
 ┃ ┣ Movie.cshtml.cs
 ┃ ┣ PossibleDiscount.cshtml
 ┃ ┣ PossibleDiscount.cshtml.cs
 ┃ ┣ Showing.cshtml
 ┃ ┣ Showing.cshtml.cs
 ┃ ┣ Theatre.cshtml
 ┃ ┗ Theatre.cshtml.cs
 ┣ image
 ┣ obj
 ┃ ┣ Debug
 ┃ ┃ ┗ net6.0
 ┃ ┃ ┃ ┣ ref
 ┃ ┃ ┃ ┃ ┗ WebApp.dll
 ┃ ┃ ┃ ┣ scopedcss
 ┃ ┃ ┃ ┃ ┣ bundle
 ┃ ┃ ┃ ┃ ┃ ┗ WebApp.styles.css
 ┃ ┃ ┃ ┃ ┣ Pages
 ┃ ┃ ┃ ┃ ┃ ┗ Remove
 ┃ ┃ ┃ ┃ ┗ projectbundle
 ┃ ┃ ┃ ┣ staticwebassets
 ┃ ┃ ┃ ┣ win10-x64
 ┃ ┃ ┃ ┃ ┣ ref
 ┃ ┃ ┃ ┃ ┃ ┗ WebApp.dll
 ┃ ┃ ┃ ┃ ┣ staticwebassets
 ┃ ┃ ┃ ┃ ┣ .NETCoreApp,Version=v6.0.AssemblyAttributes.cs
 ┃ ┃ ┃ ┃ ┣ apphost.exe
 ┃ ┃ ┃ ┃ ┣ PublishOutputs.22358cce95.txt
 ┃ ┃ ┃ ┃ ┣ WebApp.AssemblyInfo.cs
 ┃ ┃ ┃ ┃ ┣ WebApp.AssemblyInfoInputs.cache
 ┃ ┃ ┃ ┃ ┣ WebApp.assets.cache
 ┃ ┃ ┃ ┃ ┣ WebApp.csproj.AssemblyReference.cache
 ┃ ┃ ┃ ┃ ┣ WebApp.csproj.CopyComplete
 ┃ ┃ ┃ ┃ ┣ WebApp.csproj.CoreCompileInputs.cache
 ┃ ┃ ┃ ┃ ┣ WebApp.csproj.FileListAbsolute.txt
 ┃ ┃ ┃ ┃ ┣ WebApp.dll
 ┃ ┃ ┃ ┃ ┣ WebApp.GeneratedMSBuildEditorConfig.editorconfig
 ┃ ┃ ┃ ┃ ┣ WebApp.genruntimeconfig.cache
 ┃ ┃ ┃ ┃ ┣ WebApp.GlobalUsings.g.cs
 ┃ ┃ ┃ ┃ ┣ WebApp.MvcApplicationPartsAssemblyInfo.cache
 ┃ ┃ ┃ ┃ ┣ WebApp.pdb
 ┃ ┃ ┃ ┃ ┣ WebApp.RazorAssemblyInfo.cache
 ┃ ┃ ┃ ┃ ┗ WebApp.RazorAssemblyInfo.cs
 ┃ ┃ ┃ ┣ .NETCoreApp,Version=v6.0.AssemblyAttributes.cs
 ┃ ┃ ┃ ┣ apphost.exe
 ┃ ┃ ┃ ┣ staticwebassets.build.json
 ┃ ┃ ┃ ┣ staticwebassets.development.json
 ┃ ┃ ┃ ┣ staticwebassets.publish.json
 ┃ ┃ ┃ ┣ WebApp.AssemblyInfo.cs
 ┃ ┃ ┃ ┣ WebApp.AssemblyInfoInputs.cache
 ┃ ┃ ┃ ┣ WebApp.assets.cache
 ┃ ┃ ┃ ┣ WebApp.csproj.AssemblyReference.cache
 ┃ ┃ ┃ ┣ WebApp.csproj.CopyComplete
 ┃ ┃ ┃ ┣ WebApp.csproj.CoreCompileInputs.cache
 ┃ ┃ ┃ ┣ WebApp.csproj.FileListAbsolute.txt
 ┃ ┃ ┃ ┣ WebApp.dll
 ┃ ┃ ┃ ┣ WebApp.GeneratedMSBuildEditorConfig.editorconfig
 ┃ ┃ ┃ ┣ WebApp.genruntimeconfig.cache
 ┃ ┃ ┃ ┣ WebApp.GlobalUsings.g.cs
 ┃ ┃ ┃ ┣ WebApp.MvcApplicationPartsAssemblyInfo.cache
 ┃ ┃ ┃ ┣ WebApp.pdb
 ┃ ┃ ┃ ┣ WebApp.RazorAssemblyInfo.cache
 ┃ ┃ ┃ ┗ WebApp.RazorAssemblyInfo.cs
 ┃ ┣ Release
 ┃ ┃ ┗ net6.0
 ┃ ┃ ┃ ┣ ref
 ┃ ┃ ┃ ┣ staticwebassets
 ┃ ┃ ┃ ┣ win10-x64
 ┃ ┃ ┃ ┃ ┣ ref
 ┃ ┃ ┃ ┃ ┃ ┗ WebApp.dll
 ┃ ┃ ┃ ┃ ┣ staticwebassets
 ┃ ┃ ┃ ┃ ┣ .NETCoreApp,Version=v6.0.AssemblyAttributes.cs
 ┃ ┃ ┃ ┃ ┣ apphost.exe
 ┃ ┃ ┃ ┃ ┣ PublishOutputs.b68852071b.txt
 ┃ ┃ ┃ ┃ ┣ WebApp.AssemblyInfo.cs
 ┃ ┃ ┃ ┃ ┣ WebApp.AssemblyInfoInputs.cache
 ┃ ┃ ┃ ┃ ┣ WebApp.assets.cache
 ┃ ┃ ┃ ┃ ┣ WebApp.csproj.AssemblyReference.cache
 ┃ ┃ ┃ ┃ ┣ WebApp.csproj.CopyComplete
 ┃ ┃ ┃ ┃ ┣ WebApp.csproj.CoreCompileInputs.cache
 ┃ ┃ ┃ ┃ ┣ WebApp.csproj.FileListAbsolute.txt
 ┃ ┃ ┃ ┃ ┣ WebApp.dll
 ┃ ┃ ┃ ┃ ┣ WebApp.GeneratedMSBuildEditorConfig.editorconfig
 ┃ ┃ ┃ ┃ ┣ WebApp.genruntimeconfig.cache
 ┃ ┃ ┃ ┃ ┣ WebApp.GlobalUsings.g.cs
 ┃ ┃ ┃ ┃ ┣ WebApp.MvcApplicationPartsAssemblyInfo.cache
 ┃ ┃ ┃ ┃ ┣ WebApp.pdb
 ┃ ┃ ┃ ┃ ┣ WebApp.RazorAssemblyInfo.cache
 ┃ ┃ ┃ ┃ ┗ WebApp.RazorAssemblyInfo.cs
 ┃ ┃ ┃ ┣ .NETCoreApp,Version=v6.0.AssemblyAttributes.cs
 ┃ ┃ ┃ ┣ staticwebassets.build.json
 ┃ ┃ ┃ ┣ staticwebassets.development.json
 ┃ ┃ ┃ ┣ staticwebassets.publish.json
 ┃ ┃ ┃ ┣ WebApp.AssemblyInfo.cs
 ┃ ┃ ┃ ┣ WebApp.AssemblyInfoInputs.cache
 ┃ ┃ ┃ ┣ WebApp.assets.cache
 ┃ ┃ ┃ ┣ WebApp.csproj.AssemblyReference.cache
 ┃ ┃ ┃ ┣ WebApp.GeneratedMSBuildEditorConfig.editorconfig
 ┃ ┃ ┃ ┣ WebApp.GlobalUsings.g.cs
 ┃ ┃ ┃ ┣ WebApp.RazorAssemblyInfo.cache
 ┃ ┃ ┃ ┗ WebApp.RazorAssemblyInfo.cs
 ┃ ┣ project.assets.json
 ┃ ┣ project.nuget.cache
 ┃ ┣ staticwebassets.pack.sentinel
 ┃ ┣ WebApp.csproj.nuget.dgspec.json
 ┃ ┣ WebApp.csproj.nuget.g.props
 ┃ ┗ WebApp.csproj.nuget.g.targets
 ┣ Pages
 ┃ ┣ AccessDenied
 ┃ ┃ ┣ AccessDenied.cshtml
 ┃ ┃ ┗ AccessDenied.cshtml.cs
 ┃ ┣ AccountManagement
 ┃ ┃ ┣ AccountManagement.cshtml
 ┃ ┃ ┗ AccountManagement.cshtml.cs
 ┃ ┣ Booking
 ┃ ┃ ┣ Create.cs
 ┃ ┃ ┗ Create.cshtml
 ┃ ┣ Create
 ┃ ┃ ┣ CreateAccount.cshtml
 ┃ ┃ ┣ CreateAccount.cshtml.cs
 ┃ ┃ ┣ CreateActor.cshtml
 ┃ ┃ ┣ CreateActor.cshtml.cs
 ┃ ┃ ┣ CreateBuilding.cshtml
 ┃ ┃ ┣ CreateBuilding.cshtml.cs
 ┃ ┃ ┣ CreateDirector.cshtml
 ┃ ┃ ┣ CreateDirector.cshtml.cs
 ┃ ┃ ┣ CreateMovie.cshtml
 ┃ ┃ ┣ CreateMovie.cshtml.cs
 ┃ ┃ ┣ CreateShowing.cshtml
 ┃ ┃ ┗ CreateShowing.cshtml.cs
 ┃ ┣ FAQ
 ┃ ┃ ┣ FAQ.cs
 ┃ ┃ ┗ FAQ.cshtml
 ┃ ┣ Login
 ┃ ┃ ┣ Login.cshtml
 ┃ ┃ ┗ Login.cshtml.cs
 ┃ ┣ Logout
 ┃ ┃ ┗ Logout.cshtml.cs
 ┃ ┣ Remove
 ┃ ┃ ┣ RemoveBookingCustomer.cshtml
 ┃ ┃ ┣ RemoveBookingCustomer.cshtml.cs
 ┃ ┃ ┣ RemoveBookingStaff.cshtml
 ┃ ┃ ┣ RemoveBookingStaff.cshtml.cs
 ┃ ┃ ┣ RemoveMovie.cs
 ┃ ┃ ┣ RemoveMovie.cshtml
 ┃ ┃ ┣ RemoveShowing.cshtml
 ┃ ┃ ┗ RemoveShowing.cshtml.cs
 ┃ ┣ Shared
 ┃ ┃ ┣ style.css
 ┃ ┃ ┣ _Layout.cshtml
 ┃ ┃ ┗ _LoginStatus.cshtml
 ┃ ┣ Staff
 ┃ ┃ ┣ Admin.cshtml
 ┃ ┃ ┣ Create.cshtml
 ┃ ┃ ┣ Manage.cshtml
 ┃ ┃ ┣ Staff.cshtml
 ┃ ┃ ┗ Staff.cshtml.cs
 ┃ ┣ Index.cshtml
 ┃ ┣ Index.cshtml.cs
 ┃ ┗ _ViewStart.cshtml
 ┣ Properties
 ┃ ┗ launchSettings.json
 ┣ wwwroot
 ┃ ┣ 12.png
 ┃ ┣ 15.png
 ┃ ┣ 18.png
 ┃ ┣ PG.png
 ┃ ┣ place.png
 ┃ ┗ U.png
 ┣ appsettings.Development.json
 ┣ appsettings.json
 ┣ Startup.cs
 ┣ WebApp.cs
 ┗ WebApp.csproj
```




Python Project
```
 Python QR Scanner
 ┣ .idea
 ┃ ┣ inspectionProfiles
 ┃ ┃ ┗ profiles_settings.xml
 ┃ ┣ .gitignore
 ┃ ┣ misc.xml
 ┃ ┣ modules.xml
 ┃ ┣ Python QR Scanner.iml
 ┃ ┣ vcs.xml
 ┃ ┗ workspace.xml
 ┣ build
 ┃ ┣ build
 ┃ ┣ filename
 ┃ ┗ main
 ┃ ┃ ┣ Analysis-00.toc
 ┃ ┃ ┣ base_library.zip
 ┃ ┃ ┣ EXE-00.toc
 ┃ ┃ ┣ main.exe.manifest
 ┃ ┃ ┣ main.pkg
 ┃ ┃ ┣ PKG-00.toc
 ┃ ┃ ┣ PYZ-00.pyz
 ┃ ┃ ┣ PYZ-00.toc
 ┃ ┃ ┣ Tree-00.toc
 ┃ ┃ ┣ Tree-01.toc
 ┃ ┃ ┣ Tree-02.toc
 ┃ ┃ ┣ warn-main.txt
 ┃ ┃ ┗ xref-main.html
 ┣ venv
 ┃ ┣ include
 ┃ ┃ ┗ site
 ┃ ┃ ┃ ┗ python3.9
 ┃ ┃ ┃ ┃ ┗ greenlet
 ┃ ┃ ┃ ┃ ┃ ┗ greenlet.h
 ┃ ┣ Lib
 ┃ ┃ ┗ site-packages
 ┃ ┃ ┃ ┣ altgraph
 ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┣ Dot.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ Graph.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ GraphAlgo.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ GraphStat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ GraphUtil.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ ObjectGraph.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┣ Dot.py
 ┃ ┃ ┃ ┃ ┣ Graph.py
 ┃ ┃ ┃ ┃ ┣ GraphAlgo.py
 ┃ ┃ ┃ ┃ ┣ GraphStat.py
 ┃ ┃ ┃ ┃ ┣ GraphUtil.py
 ┃ ┃ ┃ ┃ ┣ ObjectGraph.py
 ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┣ altgraph-0.17.2.dist-info
 ┃ ┃ ┃ ┃ ┣ INSTALLER
 ┃ ┃ ┃ ┃ ┣ LICENSE
 ┃ ┃ ┃ ┃ ┣ METADATA
 ┃ ┃ ┃ ┃ ┣ RECORD
 ┃ ┃ ┃ ┃ ┣ top_level.txt
 ┃ ┃ ┃ ┃ ┣ WHEEL
 ┃ ┃ ┃ ┃ ┗ zip-safe
 ┃ ┃ ┃ ┣ auto_py_to_exe
 ┃ ┃ ┃ ┃ ┣ web
 ┃ ┃ ┃ ┃ ┃ ┣ css
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ general.css
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ main.css
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ modal.css
 ┃ ┃ ┃ ┃ ┃ ┣ img
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ chevron-square-up.svg
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ plus.svg
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ remove.svg
 ┃ ┃ ┃ ┃ ┃ ┣ js
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ configuration.js
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ constants.js
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ i18n.js
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ importExport.js
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ initialise.js
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ interface.js
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ messages.js
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ modal.js
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ packaging.js
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ staticEvents.js
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ utils.js
 ┃ ┃ ┃ ┃ ┃ ┣ favicon.ico
 ┃ ┃ ┃ ┃ ┃ ┣ index.html
 ┃ ┃ ┃ ┃ ┃ ┗ Nunito-Light.ttf
 ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┣ config.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ dialogs.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ packaging.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ ui.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ utils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ validation.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┗ __main__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┣ config.py
 ┃ ┃ ┃ ┃ ┣ dialogs.py
 ┃ ┃ ┃ ┃ ┣ packaging.py
 ┃ ┃ ┃ ┃ ┣ ui.py
 ┃ ┃ ┃ ┃ ┣ utils.py
 ┃ ┃ ┃ ┃ ┣ validation.py
 ┃ ┃ ┃ ┃ ┣ __init__.py
 ┃ ┃ ┃ ┃ ┗ __main__.py
 ┃ ┃ ┃ ┣ auto_py_to_exe-2.18.0.dist-info
 ┃ ┃ ┃ ┃ ┣ entry_points.txt
 ┃ ┃ ┃ ┃ ┣ INSTALLER
 ┃ ┃ ┃ ┃ ┣ LICENSE
 ┃ ┃ ┃ ┃ ┣ METADATA
 ┃ ┃ ┃ ┃ ┣ RECORD
 ┃ ┃ ┃ ┃ ┣ REQUESTED
 ┃ ┃ ┃ ┃ ┣ top_level.txt
 ┃ ┃ ┃ ┃ ┗ WHEEL
 ┃ ┃ ┃ ┣ bottle-0.12.19.dist-info
 ┃ ┃ ┃ ┃ ┣ AUTHORS
 ┃ ┃ ┃ ┃ ┣ INSTALLER
 ┃ ┃ ┃ ┃ ┣ LICENSE
 ┃ ┃ ┃ ┃ ┣ METADATA
 ┃ ┃ ┃ ┃ ┣ RECORD
 ┃ ┃ ┃ ┃ ┣ top_level.txt
 ┃ ┃ ┃ ┃ ┗ WHEEL
 ┃ ┃ ┃ ┣ bottle_websocket
 ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┣ plugin.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ server.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┣ plugin.py
 ┃ ┃ ┃ ┃ ┣ server.py
 ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┣ bottle_websocket-0.2.9.dist-info
 ┃ ┃ ┃ ┃ ┣ INSTALLER
 ┃ ┃ ┃ ┃ ┣ METADATA
 ┃ ┃ ┃ ┃ ┣ RECORD
 ┃ ┃ ┃ ┃ ┣ top_level.txt
 ┃ ┃ ┃ ┃ ┗ WHEEL
 ┃ ┃ ┃ ┣ cffi
 ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┣ api.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ backend_ctypes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ cffi_opcode.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ commontypes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ cparser.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ error.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ ffiplatform.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ lock.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ model.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ pkgconfig.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ recompiler.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ setuptools_ext.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ vengine_cpy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ vengine_gen.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ verifier.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┣ api.py
 ┃ ┃ ┃ ┃ ┣ backend_ctypes.py
 ┃ ┃ ┃ ┃ ┣ cffi_opcode.py
 ┃ ┃ ┃ ┃ ┣ commontypes.py
 ┃ ┃ ┃ ┃ ┣ cparser.py
 ┃ ┃ ┃ ┃ ┣ error.py
 ┃ ┃ ┃ ┃ ┣ ffiplatform.py
 ┃ ┃ ┃ ┃ ┣ lock.py
 ┃ ┃ ┃ ┃ ┣ model.py
 ┃ ┃ ┃ ┃ ┣ parse_c_type.h
 ┃ ┃ ┃ ┃ ┣ pkgconfig.py
 ┃ ┃ ┃ ┃ ┣ recompiler.py
 ┃ ┃ ┃ ┃ ┣ setuptools_ext.py
 ┃ ┃ ┃ ┃ ┣ vengine_cpy.py
 ┃ ┃ ┃ ┃ ┣ vengine_gen.py
 ┃ ┃ ┃ ┃ ┣ verifier.py
 ┃ ┃ ┃ ┃ ┣ _cffi_errors.h
 ┃ ┃ ┃ ┃ ┣ _cffi_include.h
 ┃ ┃ ┃ ┃ ┣ _embedding.h
 ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┣ cffi-1.15.0.dist-info
 ┃ ┃ ┃ ┃ ┣ entry_points.txt
 ┃ ┃ ┃ ┃ ┣ INSTALLER
 ┃ ┃ ┃ ┃ ┣ LICENSE
 ┃ ┃ ┃ ┃ ┣ METADATA
 ┃ ┃ ┃ ┃ ┣ RECORD
 ┃ ┃ ┃ ┃ ┣ top_level.txt
 ┃ ┃ ┃ ┃ ┗ WHEEL
 ┃ ┃ ┃ ┣ cv2
 ┃ ┃ ┃ ┃ ┣ data
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ haarcascade_eye.xml
 ┃ ┃ ┃ ┃ ┃ ┣ haarcascade_eye_tree_eyeglasses.xml
 ┃ ┃ ┃ ┃ ┃ ┣ haarcascade_frontalcatface.xml
 ┃ ┃ ┃ ┃ ┃ ┣ haarcascade_frontalcatface_extended.xml
 ┃ ┃ ┃ ┃ ┃ ┣ haarcascade_frontalface_alt.xml
 ┃ ┃ ┃ ┃ ┃ ┣ haarcascade_frontalface_alt2.xml
 ┃ ┃ ┃ ┃ ┃ ┣ haarcascade_frontalface_alt_tree.xml
 ┃ ┃ ┃ ┃ ┃ ┣ haarcascade_frontalface_default.xml
 ┃ ┃ ┃ ┃ ┃ ┣ haarcascade_fullbody.xml
 ┃ ┃ ┃ ┃ ┃ ┣ haarcascade_lefteye_2splits.xml
 ┃ ┃ ┃ ┃ ┃ ┣ haarcascade_licence_plate_rus_16stages.xml
 ┃ ┃ ┃ ┃ ┃ ┣ haarcascade_lowerbody.xml
 ┃ ┃ ┃ ┃ ┃ ┣ haarcascade_profileface.xml
 ┃ ┃ ┃ ┃ ┃ ┣ haarcascade_righteye_2splits.xml
 ┃ ┃ ┃ ┃ ┃ ┣ haarcascade_russian_plate_number.xml
 ┃ ┃ ┃ ┃ ┃ ┣ haarcascade_smile.xml
 ┃ ┃ ┃ ┃ ┃ ┣ haarcascade_upperbody.xml
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ gapi
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ mat_wrapper
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ misc
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ version.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ version.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ utils
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┣ config-3.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ config.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ load_config_py2.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ load_config_py3.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ version.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┣ config-3.py
 ┃ ┃ ┃ ┃ ┣ config.py
 ┃ ┃ ┃ ┃ ┣ cv2.pyd
 ┃ ┃ ┃ ┃ ┣ LICENSE-3RD-PARTY.txt
 ┃ ┃ ┃ ┃ ┣ LICENSE.txt
 ┃ ┃ ┃ ┃ ┣ load_config_py2.py
 ┃ ┃ ┃ ┃ ┣ load_config_py3.py
 ┃ ┃ ┃ ┃ ┣ opencv_videoio_ffmpeg455_64.dll
 ┃ ┃ ┃ ┃ ┣ version.py
 ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┣ dateutil
 ┃ ┃ ┃ ┃ ┣ parser
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ isoparser.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _parser.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ isoparser.py
 ┃ ┃ ┃ ┃ ┃ ┣ _parser.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ tz
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ tz.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ win.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _common.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _factories.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ tz.py
 ┃ ┃ ┃ ┃ ┃ ┣ win.py
 ┃ ┃ ┃ ┃ ┃ ┣ _common.py
 ┃ ┃ ┃ ┃ ┃ ┣ _factories.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ zoneinfo
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ rebuild.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ dateutil-zoneinfo.tar.gz
 ┃ ┃ ┃ ┃ ┃ ┣ rebuild.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┣ easter.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ relativedelta.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ rrule.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ tzwin.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ utils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _common.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _version.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┣ easter.py
 ┃ ┃ ┃ ┃ ┣ relativedelta.py
 ┃ ┃ ┃ ┃ ┣ rrule.py
 ┃ ┃ ┃ ┃ ┣ tzwin.py
 ┃ ┃ ┃ ┃ ┣ utils.py
 ┃ ┃ ┃ ┃ ┣ _common.py
 ┃ ┃ ┃ ┃ ┣ _version.py
 ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┣ eel
 ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┣ browsers.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ chrome.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ edge.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ electron.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┗ __main__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┣ browsers.py
 ┃ ┃ ┃ ┃ ┣ chrome.py
 ┃ ┃ ┃ ┃ ┣ edge.py
 ┃ ┃ ┃ ┃ ┣ eel.js
 ┃ ┃ ┃ ┃ ┣ electron.py
 ┃ ┃ ┃ ┃ ┣ __init__.py
 ┃ ┃ ┃ ┃ ┗ __main__.py
 ┃ ┃ ┃ ┣ Eel-0.12.4.dist-info
 ┃ ┃ ┃ ┃ ┣ INSTALLER
 ┃ ┃ ┃ ┃ ┣ METADATA
 ┃ ┃ ┃ ┃ ┣ RECORD
 ┃ ┃ ┃ ┃ ┣ top_level.txt
 ┃ ┃ ┃ ┃ ┗ WHEEL
 ┃ ┃ ┃ ┣ future
 ┃ ┃ ┃ ┃ ┣ backports
 ┃ ┃ ┃ ┃ ┃ ┣ email
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ mime
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ application.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ audio.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ base.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ image.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ message.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ multipart.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ nonmultipart.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ text.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ application.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ audio.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ base.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ image.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ message.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ multipart.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ nonmultipart.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ text.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ base64mime.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ charset.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ encoders.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ errors.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ feedparser.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ generator.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ header.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ headerregistry.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ iterators.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ message.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ parser.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ policy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ quoprimime.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ utils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _encoded_words.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _header_value_parser.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _parseaddr.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _policybase.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ base64mime.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ charset.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ encoders.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ errors.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ feedparser.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ generator.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ header.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ headerregistry.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ iterators.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ message.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ parser.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ policy.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ quoprimime.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ utils.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _encoded_words.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _header_value_parser.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _parseaddr.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _policybase.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ html
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ entities.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ parser.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ entities.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ parser.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ http
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ client.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ cookiejar.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ cookies.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ server.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ client.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cookiejar.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cookies.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ server.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ test
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pystone.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ssl_servers.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ support.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ badcert.pem
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ badkey.pem
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ dh512.pem
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ https_svn_python_org_root.pem
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ keycert.passwd.pem
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ keycert.pem
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ keycert2.pem
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ nokia.pem
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ nullbytecert.pem
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ nullcert.pem
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pystone.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ sha256.pem
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ ssl_cert.pem
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ ssl_key.passwd.pem
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ ssl_key.pem
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ ssl_servers.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ support.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ urllib
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ error.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ parse.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ request.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ response.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ robotparser.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ error.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ parse.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ request.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ response.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ robotparser.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ xmlrpc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ client.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ server.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ client.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ server.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ datetime.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ misc.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ socket.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ socketserver.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ total_ordering.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _markupbase.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ datetime.py
 ┃ ┃ ┃ ┃ ┃ ┣ misc.py
 ┃ ┃ ┃ ┃ ┃ ┣ socket.py
 ┃ ┃ ┃ ┃ ┃ ┣ socketserver.py
 ┃ ┃ ┃ ┃ ┃ ┣ total_ordering.py
 ┃ ┃ ┃ ┃ ┃ ┣ _markupbase.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ builtins
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ disabled.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ iterators.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ misc.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ newnext.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ newround.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ newsuper.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ new_min_max.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ disabled.py
 ┃ ┃ ┃ ┃ ┃ ┣ iterators.py
 ┃ ┃ ┃ ┃ ┃ ┣ misc.py
 ┃ ┃ ┃ ┃ ┃ ┣ newnext.py
 ┃ ┃ ┃ ┃ ┃ ┣ newround.py
 ┃ ┃ ┃ ┃ ┃ ┣ newsuper.py
 ┃ ┃ ┃ ┃ ┃ ┣ new_min_max.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ moves
 ┃ ┃ ┃ ┃ ┃ ┣ dbm
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ dumb.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ gnu.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ndbm.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ dumb.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ gnu.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ ndbm.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ html
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ entities.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ parser.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ entities.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ parser.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ http
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ client.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ cookiejar.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ cookies.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ server.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ client.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cookiejar.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cookies.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ server.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ test
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ support.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ support.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ tkinter
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ colorchooser.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ commondialog.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ constants.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ dialog.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ dnd.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ filedialog.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ font.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ messagebox.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ scrolledtext.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ simpledialog.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ tix.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ttk.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ colorchooser.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ commondialog.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ constants.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ dialog.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ dnd.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ filedialog.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ font.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ messagebox.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ scrolledtext.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ simpledialog.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ tix.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ ttk.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ urllib
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ error.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ parse.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ request.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ response.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ robotparser.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ error.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ parse.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ request.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ response.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ robotparser.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ xmlrpc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ client.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ server.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ client.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ server.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ builtins.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ collections.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ configparser.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ copyreg.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ itertools.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pickle.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ queue.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ reprlib.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ socketserver.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ subprocess.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ sys.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ winreg.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _dummy_thread.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _markupbase.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _thread.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ builtins.py
 ┃ ┃ ┃ ┃ ┃ ┣ collections.py
 ┃ ┃ ┃ ┃ ┃ ┣ configparser.py
 ┃ ┃ ┃ ┃ ┃ ┣ copyreg.py
 ┃ ┃ ┃ ┃ ┃ ┣ itertools.py
 ┃ ┃ ┃ ┃ ┃ ┣ pickle.py
 ┃ ┃ ┃ ┃ ┃ ┣ queue.py
 ┃ ┃ ┃ ┃ ┃ ┣ reprlib.py
 ┃ ┃ ┃ ┃ ┃ ┣ socketserver.py
 ┃ ┃ ┃ ┃ ┃ ┣ subprocess.py
 ┃ ┃ ┃ ┃ ┃ ┣ sys.py
 ┃ ┃ ┃ ┃ ┃ ┣ winreg.py
 ┃ ┃ ┃ ┃ ┃ ┣ _dummy_thread.py
 ┃ ┃ ┃ ┃ ┃ ┣ _markupbase.py
 ┃ ┃ ┃ ┃ ┃ ┣ _thread.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ standard_library
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ tests
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ base.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ base.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ types
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ newbytes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ newdict.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ newint.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ newlist.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ newmemoryview.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ newobject.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ newopen.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ newrange.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ newstr.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ newbytes.py
 ┃ ┃ ┃ ┃ ┃ ┣ newdict.py
 ┃ ┃ ┃ ┃ ┃ ┣ newint.py
 ┃ ┃ ┃ ┃ ┃ ┣ newlist.py
 ┃ ┃ ┃ ┃ ┃ ┣ newmemoryview.py
 ┃ ┃ ┃ ┃ ┃ ┣ newobject.py
 ┃ ┃ ┃ ┃ ┃ ┣ newopen.py
 ┃ ┃ ┃ ┃ ┃ ┣ newrange.py
 ┃ ┃ ┃ ┃ ┃ ┣ newstr.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ utils
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ surrogateescape.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ surrogateescape.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┣ future-0.18.2.dist-info
 ┃ ┃ ┃ ┃ ┣ entry_points.txt
 ┃ ┃ ┃ ┃ ┣ INSTALLER
 ┃ ┃ ┃ ┃ ┣ LICENSE.txt
 ┃ ┃ ┃ ┃ ┣ METADATA
 ┃ ┃ ┃ ┃ ┣ RECORD
 ┃ ┃ ┃ ┃ ┣ top_level.txt
 ┃ ┃ ┃ ┃ ┗ WHEEL
 ┃ ┃ ┃ ┣ gevent
 ┃ ┃ ┃ ┃ ┣ libev
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ corecffi.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ watcher.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _corecffi_build.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ corecext.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ corecffi.py
 ┃ ┃ ┃ ┃ ┃ ┣ watcher.py
 ┃ ┃ ┃ ┃ ┃ ┣ _corecffi_build.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ libuv
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ loop.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ watcher.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _corecffi_build.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ loop.py
 ┃ ┃ ┃ ┃ ┃ ┣ watcher.py
 ┃ ┃ ┃ ┃ ┃ ┣ _corecffi.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ _corecffi_build.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ resolver
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ ares.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ blocking.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ dnspython.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ thread.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _addresses.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _hostsfile.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ ares.py
 ┃ ┃ ┃ ┃ ┃ ┣ blocking.py
 ┃ ┃ ┃ ┃ ┃ ┣ dnspython.py
 ┃ ┃ ┃ ┃ ┃ ┣ thread.py
 ┃ ┃ ┃ ┃ ┃ ┣ _addresses.py
 ┃ ┃ ┃ ┃ ┃ ┣ _hostsfile.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ testing
 ┃ ┃ ┃ ┃ ┃ ┣ coveragesite
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ sitecustomize.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ sitecustomize.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ errorhandler.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ exception.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ flaky.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hub.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ leakcheck.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ modules.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ monkey_test.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ openfiles.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ params.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ patched_tests_setup.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ resources.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ six.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ skipping.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ sockets.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ support.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ switching.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ sysinfo.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ testcase.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ testrunner.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ timing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ travis.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ util.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ errorhandler.py
 ┃ ┃ ┃ ┃ ┃ ┣ exception.py
 ┃ ┃ ┃ ┃ ┃ ┣ flaky.py
 ┃ ┃ ┃ ┃ ┃ ┣ hub.py
 ┃ ┃ ┃ ┃ ┃ ┣ leakcheck.py
 ┃ ┃ ┃ ┃ ┃ ┣ modules.py
 ┃ ┃ ┃ ┃ ┃ ┣ monkey_test.py
 ┃ ┃ ┃ ┃ ┃ ┣ openfiles.py
 ┃ ┃ ┃ ┃ ┃ ┣ params.py
 ┃ ┃ ┃ ┃ ┃ ┣ patched_tests_setup.py
 ┃ ┃ ┃ ┃ ┃ ┣ resources.py
 ┃ ┃ ┃ ┃ ┃ ┣ six.py
 ┃ ┃ ┃ ┃ ┃ ┣ skipping.py
 ┃ ┃ ┃ ┃ ┃ ┣ sockets.py
 ┃ ┃ ┃ ┃ ┃ ┣ support.py
 ┃ ┃ ┃ ┃ ┃ ┣ switching.py
 ┃ ┃ ┃ ┃ ┃ ┣ sysinfo.py
 ┃ ┃ ┃ ┃ ┃ ┣ testcase.py
 ┃ ┃ ┃ ┃ ┃ ┣ testrunner.py
 ┃ ┃ ┃ ┃ ┃ ┣ timing.py
 ┃ ┃ ┃ ┃ ┃ ┣ travis.py
 ┃ ┃ ┃ ┃ ┃ ┣ util.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ tests
 ┃ ┃ ┃ ┃ ┃ ┣ monkey_package
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ issue1526_no_monkey.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ issue1526_with_monkey.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ issue302monkey.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ script.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ threadpool_monkey_patches.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ threadpool_no_monkey.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __main__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ issue1526_no_monkey.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ issue1526_with_monkey.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ issue302monkey.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ script.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ threadpool_monkey_patches.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ threadpool_no_monkey.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __main__.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ getaddrinfo_module.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ known_failures.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ lock_tests.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__all__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__api.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__api_timeout.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__ares_host_result.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__ares_timeout.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__backdoor.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__close_backend_fd.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__compat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__contextvars.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__core.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__core_async.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__core_callback.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__core_fork.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__core_loop_run.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__core_stat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__core_timer.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__core_watcher.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__destroy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__destroy_default_loop.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__doctests.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__environ.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__event.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__events.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__examples.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__example_echoserver.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__example_portforwarder.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__example_udp_client.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__example_udp_server.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__example_webproxy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__example_wsgiserver.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__example_wsgiserver_ssl.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__exc_info.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__execmodules.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__fileobject.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__getaddrinfo_import.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__greenio.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__greenlet.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__GreenletExit.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__greenletset.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__greenness.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__hub.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__hub_join.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__hub_join_timeout.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__import_blocking_in_greenlet.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__import_wait.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__issue112.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__issue1686.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__issue230.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__issue330.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__issue467.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__issue6.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__issue600.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__issue607.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__issue639.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__issues461_471.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__issue_728.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__iwait.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__joinall.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__local.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__lock.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__loop_callback.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__makefile_ref.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__memleak.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__monkey.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__monkey_builtins_future.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__monkey_futures_thread.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__monkey_hub_in_thread.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__monkey_logging.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__monkey_module_run.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__monkey_multiple_imports.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__monkey_queue.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__monkey_select.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__monkey_selectors.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__monkey_sigchld.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__monkey_sigchld_2.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__monkey_sigchld_3.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__monkey_ssl_warning.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__monkey_ssl_warning2.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__monkey_ssl_warning3.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__nondefaultloop.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__order.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__os.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__pool.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__pywsgi.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__queue.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__real_greenlet.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__refcount.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__refcount_core.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__resolver_dnspython.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__select.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__selectors.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__semaphore.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__server.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__server_pywsgi.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__signal.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__sleep0.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__socket.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__socketpair.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__socket_close.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__socket_dns.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__socket_dns6.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__socket_errors.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__socket_ex.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__socket_send_memoryview.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__socket_ssl.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__socket_timeout.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__ssl.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__subprocess.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__subprocess_interrupted.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__subprocess_poll.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__systemerror.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__thread.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__threading.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__threading_2.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__threading_before_monkey.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__threading_holding_lock_while_monkey.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__threading_monkey_in_thread.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__threading_native_before_monkey.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__threading_no_monkey.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__threading_patched_local.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__threading_vs_settrace.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__threadpool.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__threadpool_executor_patched.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__timeout.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__util.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test___config.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test___ident.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test___monitor.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test___monkey_patching.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _blocks_at_top_level.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _imports_at_top_level.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _imports_imports_at_top_level.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _import_import_patch.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _import_patch.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _import_wait.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __main__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ 2_7_keycert.pem
 ┃ ┃ ┃ ┃ ┃ ┣ badcert.pem
 ┃ ┃ ┃ ┃ ┃ ┣ badkey.pem
 ┃ ┃ ┃ ┃ ┃ ┣ getaddrinfo_module.py
 ┃ ┃ ┃ ┃ ┃ ┣ hosts_file.txt
 ┃ ┃ ┃ ┃ ┃ ┣ https_svn_python_org_root.pem
 ┃ ┃ ┃ ┃ ┃ ┣ keycert.pem
 ┃ ┃ ┃ ┃ ┃ ┣ known_failures.py
 ┃ ┃ ┃ ┃ ┃ ┣ lock_tests.py
 ┃ ┃ ┃ ┃ ┃ ┣ nullcert.pem
 ┃ ┃ ┃ ┃ ┃ ┣ server.crt
 ┃ ┃ ┃ ┃ ┃ ┣ server.key
 ┃ ┃ ┃ ┃ ┃ ┣ sha256.pem
 ┃ ┃ ┃ ┃ ┃ ┣ tests_that_dont_do_leakchecks.txt
 ┃ ┃ ┃ ┃ ┃ ┣ tests_that_dont_monkeypatch.txt
 ┃ ┃ ┃ ┃ ┃ ┣ tests_that_dont_use_resolver.txt
 ┃ ┃ ┃ ┃ ┃ ┣ test_server.crt
 ┃ ┃ ┃ ┃ ┃ ┣ test_server.key
 ┃ ┃ ┃ ┃ ┃ ┣ test__all__.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__api.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__api_timeout.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__ares_host_result.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__ares_timeout.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__backdoor.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__close_backend_fd.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__compat.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__contextvars.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__core.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__core_async.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__core_callback.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__core_fork.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__core_loop_run.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__core_stat.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__core_timer.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__core_watcher.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__destroy.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__destroy_default_loop.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__doctests.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__environ.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__event.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__events.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__examples.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__example_echoserver.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__example_portforwarder.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__example_udp_client.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__example_udp_server.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__example_webproxy.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__example_wsgiserver.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__example_wsgiserver_ssl.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__exc_info.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__execmodules.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__fileobject.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__getaddrinfo_import.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__greenio.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__greenlet.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__GreenletExit.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__greenletset.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__greenness.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__hub.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__hub_join.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__hub_join_timeout.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__import_blocking_in_greenlet.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__import_wait.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__issue112.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__issue1686.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__issue230.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__issue330.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__issue467.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__issue6.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__issue600.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__issue607.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__issue639.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__issues461_471.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__issue_728.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__iwait.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__joinall.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__local.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__lock.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__loop_callback.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__makefile_ref.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__memleak.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__monkey.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__monkey_builtins_future.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__monkey_futures_thread.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__monkey_hub_in_thread.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__monkey_logging.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__monkey_module_run.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__monkey_multiple_imports.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__monkey_queue.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__monkey_select.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__monkey_selectors.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__monkey_sigchld.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__monkey_sigchld_2.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__monkey_sigchld_3.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__monkey_ssl_warning.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__monkey_ssl_warning2.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__monkey_ssl_warning3.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__nondefaultloop.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__order.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__os.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__pool.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__pywsgi.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__queue.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__real_greenlet.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__refcount.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__refcount_core.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__resolver_dnspython.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__select.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__selectors.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__semaphore.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__server.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__server_pywsgi.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__signal.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__sleep0.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__socket.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__socketpair.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__socket_close.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__socket_dns.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__socket_dns6.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__socket_errors.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__socket_ex.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__socket_send_memoryview.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__socket_ssl.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__socket_timeout.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__ssl.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__subprocess.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__subprocess_interrupted.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__subprocess_poll.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__systemerror.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__thread.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__threading.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__threading_2.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__threading_before_monkey.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__threading_holding_lock_while_monkey.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__threading_monkey_in_thread.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__threading_native_before_monkey.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__threading_no_monkey.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__threading_patched_local.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__threading_vs_settrace.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__threadpool.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__threadpool_executor_patched.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__timeout.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__util.py
 ┃ ┃ ┃ ┃ ┃ ┣ test___config.py
 ┃ ┃ ┃ ┃ ┃ ┣ test___ident.py
 ┃ ┃ ┃ ┃ ┃ ┣ test___monitor.py
 ┃ ┃ ┃ ┃ ┃ ┣ test___monkey_patching.py
 ┃ ┃ ┃ ┃ ┃ ┣ wrongcert.pem
 ┃ ┃ ┃ ┃ ┃ ┣ _blocks_at_top_level.py
 ┃ ┃ ┃ ┃ ┃ ┣ _imports_at_top_level.py
 ┃ ┃ ┃ ┃ ┃ ┣ _imports_imports_at_top_level.py
 ┃ ┃ ┃ ┃ ┃ ┣ _import_import_patch.py
 ┃ ┃ ┃ ┃ ┃ ┣ _import_patch.py
 ┃ ┃ ┃ ┃ ┃ ┣ _import_wait.py
 ┃ ┃ ┃ ┃ ┃ ┣ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┗ __main__.py
 ┃ ┃ ┃ ┃ ┣ _ffi
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ callback.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ loop.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ watcher.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ callback.py
 ┃ ┃ ┃ ┃ ┃ ┣ loop.py
 ┃ ┃ ┃ ┃ ┃ ┣ watcher.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┣ ares.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ backdoor.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ baseserver.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ builtins.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ contextvars.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ core.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ event.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ events.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ exceptions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ fileobject.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ greenlet.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ hub.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ local.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ lock.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ monkey.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ os.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ pool.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ pywsgi.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ queue.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ resolver_ares.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ resolver_thread.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ select.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ selectors.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ server.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ signal.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ socket.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ ssl.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ subprocess.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ thread.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ threading.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ threadpool.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ time.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ timeout.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ util.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ win32util.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _abstract_linkable.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _compat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _config.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _fileobjectcommon.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _fileobjectposix.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _greenlet_primitives.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _hub_local.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _hub_primitives.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _ident.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _imap.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _interfaces.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _monitor.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _patcher.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _semaphore.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _socket2.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _socket3.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _socketcommon.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _ssl2.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _ssl3.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _sslgte279.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _tblib.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _threading.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _tracer.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _util.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _util_py2.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _waiter.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┣ ares.py
 ┃ ┃ ┃ ┃ ┣ backdoor.py
 ┃ ┃ ┃ ┃ ┣ baseserver.py
 ┃ ┃ ┃ ┃ ┣ builtins.py
 ┃ ┃ ┃ ┃ ┣ contextvars.py
 ┃ ┃ ┃ ┃ ┣ core.py
 ┃ ┃ ┃ ┃ ┣ event.py
 ┃ ┃ ┃ ┃ ┣ events.py
 ┃ ┃ ┃ ┃ ┣ exceptions.py
 ┃ ┃ ┃ ┃ ┣ fileobject.py
 ┃ ┃ ┃ ┃ ┣ greenlet.py
 ┃ ┃ ┃ ┃ ┣ hub.py
 ┃ ┃ ┃ ┃ ┣ local.py
 ┃ ┃ ┃ ┃ ┣ lock.py
 ┃ ┃ ┃ ┃ ┣ monkey.py
 ┃ ┃ ┃ ┃ ┣ os.py
 ┃ ┃ ┃ ┃ ┣ pool.py
 ┃ ┃ ┃ ┃ ┣ pywsgi.py
 ┃ ┃ ┃ ┃ ┣ queue.py
 ┃ ┃ ┃ ┃ ┣ resolver_ares.py
 ┃ ┃ ┃ ┃ ┣ resolver_thread.py
 ┃ ┃ ┃ ┃ ┣ select.py
 ┃ ┃ ┃ ┃ ┣ selectors.py
 ┃ ┃ ┃ ┃ ┣ server.py
 ┃ ┃ ┃ ┃ ┣ signal.py
 ┃ ┃ ┃ ┃ ┣ socket.py
 ┃ ┃ ┃ ┃ ┣ ssl.py
 ┃ ┃ ┃ ┃ ┣ subprocess.py
 ┃ ┃ ┃ ┃ ┣ thread.py
 ┃ ┃ ┃ ┃ ┣ threading.py
 ┃ ┃ ┃ ┃ ┣ threadpool.py
 ┃ ┃ ┃ ┃ ┣ time.py
 ┃ ┃ ┃ ┃ ┣ timeout.py
 ┃ ┃ ┃ ┃ ┣ util.py
 ┃ ┃ ┃ ┃ ┣ win32util.py
 ┃ ┃ ┃ ┃ ┣ _abstract_linkable.py
 ┃ ┃ ┃ ┃ ┣ _compat.py
 ┃ ┃ ┃ ┃ ┣ _config.py
 ┃ ┃ ┃ ┃ ┣ _fileobjectcommon.py
 ┃ ┃ ┃ ┃ ┣ _fileobjectposix.py
 ┃ ┃ ┃ ┃ ┣ _gevent_cevent.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┣ _gevent_cgreenlet.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┣ _gevent_clocal.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┣ _gevent_cqueue.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┣ _gevent_c_abstract_linkable.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┣ _gevent_c_greenlet_primitives.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┣ _gevent_c_hub_local.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┣ _gevent_c_hub_primitives.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┣ _gevent_c_ident.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┣ _gevent_c_imap.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┣ _gevent_c_semaphore.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┣ _gevent_c_tracer.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┣ _gevent_c_waiter.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┣ _greenlet_primitives.py
 ┃ ┃ ┃ ┃ ┣ _hub_local.py
 ┃ ┃ ┃ ┃ ┣ _hub_primitives.py
 ┃ ┃ ┃ ┃ ┣ _ident.py
 ┃ ┃ ┃ ┃ ┣ _imap.py
 ┃ ┃ ┃ ┃ ┣ _interfaces.py
 ┃ ┃ ┃ ┃ ┣ _monitor.py
 ┃ ┃ ┃ ┃ ┣ _patcher.py
 ┃ ┃ ┃ ┃ ┣ _semaphore.py
 ┃ ┃ ┃ ┃ ┣ _socket2.py
 ┃ ┃ ┃ ┃ ┣ _socket3.py
 ┃ ┃ ┃ ┃ ┣ _socketcommon.py
 ┃ ┃ ┃ ┃ ┣ _ssl2.py
 ┃ ┃ ┃ ┃ ┣ _ssl3.py
 ┃ ┃ ┃ ┃ ┣ _sslgte279.py
 ┃ ┃ ┃ ┃ ┣ _tblib.py
 ┃ ┃ ┃ ┃ ┣ _threading.py
 ┃ ┃ ┃ ┃ ┣ _tracer.py
 ┃ ┃ ┃ ┃ ┣ _util.py
 ┃ ┃ ┃ ┃ ┣ _util_py2.py
 ┃ ┃ ┃ ┃ ┣ _waiter.py
 ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┣ gevent-21.12.0.dist-info
 ┃ ┃ ┃ ┃ ┣ AUTHORS
 ┃ ┃ ┃ ┃ ┣ entry_points.txt
 ┃ ┃ ┃ ┃ ┣ INSTALLER
 ┃ ┃ ┃ ┃ ┣ LICENSE
 ┃ ┃ ┃ ┃ ┣ METADATA
 ┃ ┃ ┃ ┃ ┣ NOTICE
 ┃ ┃ ┃ ┃ ┣ RECORD
 ┃ ┃ ┃ ┃ ┣ top_level.txt
 ┃ ┃ ┃ ┃ ┗ WHEEL
 ┃ ┃ ┃ ┣ geventwebsocket
 ┃ ┃ ┃ ┃ ┣ gunicorn
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ workers.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ workers.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ protocols
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ base.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ wamp.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ base.py
 ┃ ┃ ┃ ┃ ┃ ┣ wamp.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┣ exceptions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ handler.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ logging.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ resource.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ server.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ utf8validator.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ utils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ websocket.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _compat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┣ exceptions.py
 ┃ ┃ ┃ ┃ ┣ handler.py
 ┃ ┃ ┃ ┃ ┣ logging.py
 ┃ ┃ ┃ ┃ ┣ resource.py
 ┃ ┃ ┃ ┃ ┣ server.py
 ┃ ┃ ┃ ┃ ┣ utf8validator.py
 ┃ ┃ ┃ ┃ ┣ utils.py
 ┃ ┃ ┃ ┃ ┣ websocket.py
 ┃ ┃ ┃ ┃ ┣ _compat.py
 ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┣ gevent_websocket-0.10.1.dist-info
 ┃ ┃ ┃ ┃ ┣ DESCRIPTION.rst
 ┃ ┃ ┃ ┃ ┣ INSTALLER
 ┃ ┃ ┃ ┃ ┣ METADATA
 ┃ ┃ ┃ ┃ ┣ metadata.json
 ┃ ┃ ┃ ┃ ┣ RECORD
 ┃ ┃ ┃ ┃ ┣ top_level.txt
 ┃ ┃ ┃ ┃ ┗ WHEEL
 ┃ ┃ ┃ ┣ greenlet
 ┃ ┃ ┃ ┃ ┣ platform
 ┃ ┃ ┃ ┃ ┃ ┣ setup_switch_x64_masm.cmd
 ┃ ┃ ┃ ┃ ┃ ┣ switch_aarch64_gcc.h
 ┃ ┃ ┃ ┃ ┃ ┣ switch_alpha_unix.h
 ┃ ┃ ┃ ┃ ┃ ┣ switch_amd64_unix.h
 ┃ ┃ ┃ ┃ ┃ ┣ switch_arm32_gcc.h
 ┃ ┃ ┃ ┃ ┃ ┣ switch_arm32_ios.h
 ┃ ┃ ┃ ┃ ┃ ┣ switch_csky_gcc.h
 ┃ ┃ ┃ ┃ ┃ ┣ switch_m68k_gcc.h
 ┃ ┃ ┃ ┃ ┃ ┣ switch_mips_unix.h
 ┃ ┃ ┃ ┃ ┃ ┣ switch_ppc64_aix.h
 ┃ ┃ ┃ ┃ ┃ ┣ switch_ppc64_linux.h
 ┃ ┃ ┃ ┃ ┃ ┣ switch_ppc_aix.h
 ┃ ┃ ┃ ┃ ┃ ┣ switch_ppc_linux.h
 ┃ ┃ ┃ ┃ ┃ ┣ switch_ppc_macosx.h
 ┃ ┃ ┃ ┃ ┃ ┣ switch_ppc_unix.h
 ┃ ┃ ┃ ┃ ┃ ┣ switch_riscv_unix.h
 ┃ ┃ ┃ ┃ ┃ ┣ switch_s390_unix.h
 ┃ ┃ ┃ ┃ ┃ ┣ switch_sparc_sun_gcc.h
 ┃ ┃ ┃ ┃ ┃ ┣ switch_x32_unix.h
 ┃ ┃ ┃ ┃ ┃ ┣ switch_x64_masm.asm
 ┃ ┃ ┃ ┃ ┃ ┣ switch_x64_masm.obj
 ┃ ┃ ┃ ┃ ┃ ┣ switch_x64_msvc.h
 ┃ ┃ ┃ ┃ ┃ ┣ switch_x86_msvc.h
 ┃ ┃ ┃ ┃ ┃ ┗ switch_x86_unix.h
 ┃ ┃ ┃ ┃ ┣ tests
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_contextvars.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_cpp.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_extension_interface.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_gc.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_generator.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_generator_nested.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_greenlet.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_leaks.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_stack_saved.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_throw.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_tracing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_version.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_weakref.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ test_contextvars.py
 ┃ ┃ ┃ ┃ ┃ ┣ test_cpp.py
 ┃ ┃ ┃ ┃ ┃ ┣ test_extension_interface.py
 ┃ ┃ ┃ ┃ ┃ ┣ test_gc.py
 ┃ ┃ ┃ ┃ ┃ ┣ test_generator.py
 ┃ ┃ ┃ ┃ ┃ ┣ test_generator_nested.py
 ┃ ┃ ┃ ┃ ┃ ┣ test_greenlet.py
 ┃ ┃ ┃ ┃ ┃ ┣ test_leaks.py
 ┃ ┃ ┃ ┃ ┃ ┣ test_stack_saved.py
 ┃ ┃ ┃ ┃ ┃ ┣ test_throw.py
 ┃ ┃ ┃ ┃ ┃ ┣ test_tracing.py
 ┃ ┃ ┃ ┃ ┃ ┣ test_version.py
 ┃ ┃ ┃ ┃ ┃ ┣ test_weakref.py
 ┃ ┃ ┃ ┃ ┃ ┣ _test_extension.c
 ┃ ┃ ┃ ┃ ┃ ┣ _test_extension.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ _test_extension_cpp.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ _test_extension_cpp.cpp
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┣ greenlet.c
 ┃ ┃ ┃ ┃ ┣ greenlet.h
 ┃ ┃ ┃ ┃ ┣ slp_platformselect.h
 ┃ ┃ ┃ ┃ ┣ _greenlet.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┣ greenlet-1.1.2.dist-info
 ┃ ┃ ┃ ┃ ┣ AUTHORS
 ┃ ┃ ┃ ┃ ┣ INSTALLER
 ┃ ┃ ┃ ┃ ┣ LICENSE
 ┃ ┃ ┃ ┃ ┣ LICENSE.PSF
 ┃ ┃ ┃ ┃ ┣ METADATA
 ┃ ┃ ┃ ┃ ┣ RECORD
 ┃ ┃ ┃ ┃ ┣ top_level.txt
 ┃ ┃ ┃ ┃ ┗ WHEEL
 ┃ ┃ ┃ ┣ imutils
 ┃ ┃ ┃ ┃ ┣ face_utils
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ facealigner.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ helpers.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ facealigner.py
 ┃ ┃ ┃ ┃ ┃ ┣ helpers.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ feature
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ dense.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ factories.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ gftt.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ harris.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ helpers.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ rootsift.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ dense.py
 ┃ ┃ ┃ ┃ ┃ ┣ factories.py
 ┃ ┃ ┃ ┃ ┃ ┣ gftt.py
 ┃ ┃ ┃ ┃ ┃ ┣ harris.py
 ┃ ┃ ┃ ┃ ┃ ┣ helpers.py
 ┃ ┃ ┃ ┃ ┃ ┣ rootsift.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ io
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ tempfile.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ tempfile.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ video
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ count_frames.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ filevideostream.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fps.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pivideostream.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ videostream.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ webcamvideostream.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ count_frames.py
 ┃ ┃ ┃ ┃ ┃ ┣ filevideostream.py
 ┃ ┃ ┃ ┃ ┃ ┣ fps.py
 ┃ ┃ ┃ ┃ ┃ ┣ pivideostream.py
 ┃ ┃ ┃ ┃ ┃ ┣ videostream.py
 ┃ ┃ ┃ ┃ ┃ ┣ webcamvideostream.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┣ contours.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ convenience.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ encodings.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ meta.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ object_detection.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ paths.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ perspective.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ text.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┣ contours.py
 ┃ ┃ ┃ ┃ ┣ convenience.py
 ┃ ┃ ┃ ┃ ┣ encodings.py
 ┃ ┃ ┃ ┃ ┣ meta.py
 ┃ ┃ ┃ ┃ ┣ object_detection.py
 ┃ ┃ ┃ ┃ ┣ paths.py
 ┃ ┃ ┃ ┃ ┣ perspective.py
 ┃ ┃ ┃ ┃ ┣ text.py
 ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┣ imutils-0.5.4.dist-info
 ┃ ┃ ┃ ┃ ┣ INSTALLER
 ┃ ┃ ┃ ┃ ┣ METADATA
 ┃ ┃ ┃ ┃ ┣ RECORD
 ┃ ┃ ┃ ┃ ┣ REQUESTED
 ┃ ┃ ┃ ┃ ┣ top_level.txt
 ┃ ┃ ┃ ┃ ┗ WHEEL
 ┃ ┃ ┃ ┣ libfuturize
 ┃ ┃ ┃ ┃ ┣ fixes
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_absolute_import.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_add__future__imports_except_unicode_literals.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_basestring.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_bytes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_cmp.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_division.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_division_safe.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_execfile.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_future_builtins.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_future_standard_library.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_future_standard_library_urllib.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_input.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_metaclass.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_next_call.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_object.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_oldstr_wrap.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_order___future__imports.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_print.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_print_with_import.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_raise.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_remove_old__future__imports.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_unicode_keep_u.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_unicode_literals_import.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_UserDict.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_xrange_with_import.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ fix_absolute_import.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_add__future__imports_except_unicode_literals.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_basestring.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_bytes.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_cmp.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_division.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_division_safe.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_execfile.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_future_builtins.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_future_standard_library.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_future_standard_library_urllib.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_input.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_metaclass.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_next_call.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_object.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_oldstr_wrap.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_order___future__imports.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_print.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_print_with_import.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_raise.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_remove_old__future__imports.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_unicode_keep_u.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_unicode_literals_import.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_UserDict.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_xrange_with_import.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┣ fixer_util.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ main.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┣ fixer_util.py
 ┃ ┃ ┃ ┃ ┣ main.py
 ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┣ libpasteurize
 ┃ ┃ ┃ ┃ ┣ fixes
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ feature_base.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_add_all_future_builtins.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_add_all__future__imports.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_add_future_standard_library_import.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_annotations.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_division.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_features.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_fullargspec.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_future_builtins.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_getcwd.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_imports.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_imports2.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_kwargs.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_memoryview.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_metaclass.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_newstyle.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_next.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_printfunction.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_raise.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_raise_.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_throw.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fix_unpacking.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ feature_base.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_add_all_future_builtins.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_add_all__future__imports.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_add_future_standard_library_import.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_annotations.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_division.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_features.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_fullargspec.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_future_builtins.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_getcwd.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_imports.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_imports2.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_kwargs.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_memoryview.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_metaclass.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_newstyle.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_next.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_printfunction.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_raise.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_raise_.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_throw.py
 ┃ ┃ ┃ ┃ ┃ ┣ fix_unpacking.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┣ main.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┣ main.py
 ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┣ numpy
 ┃ ┃ ┃ ┃ ┣ .libs
 ┃ ┃ ┃ ┃ ┃ ┗ libopenblas.EL2C6PLE4ZYW3ECEVIV3OXXGRN2NRFM2.gfortran-win_amd64.dll
 ┃ ┃ ┃ ┃ ┣ array_api
 ┃ ┃ ┃ ┃ ┃ ┣ tests
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_array_object.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_creation_functions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_elementwise_functions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_set_functions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_sorting_functions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_array_object.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_creation_functions.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_elementwise_functions.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_set_functions.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_sorting_functions.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ linalg.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ setup.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _array_object.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _constants.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _creation_functions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _data_type_functions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _dtypes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _elementwise_functions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _manipulation_functions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _searching_functions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _set_functions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _sorting_functions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _statistical_functions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _typing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _utility_functions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ linalg.py
 ┃ ┃ ┃ ┃ ┃ ┣ setup.py
 ┃ ┃ ┃ ┃ ┃ ┣ _array_object.py
 ┃ ┃ ┃ ┃ ┃ ┣ _constants.py
 ┃ ┃ ┃ ┃ ┃ ┣ _creation_functions.py
 ┃ ┃ ┃ ┃ ┃ ┣ _data_type_functions.py
 ┃ ┃ ┃ ┃ ┃ ┣ _dtypes.py
 ┃ ┃ ┃ ┃ ┃ ┣ _elementwise_functions.py
 ┃ ┃ ┃ ┃ ┃ ┣ _manipulation_functions.py
 ┃ ┃ ┃ ┃ ┃ ┣ _searching_functions.py
 ┃ ┃ ┃ ┃ ┃ ┣ _set_functions.py
 ┃ ┃ ┃ ┃ ┃ ┣ _sorting_functions.py
 ┃ ┃ ┃ ┃ ┃ ┣ _statistical_functions.py
 ┃ ┃ ┃ ┃ ┃ ┣ _typing.py
 ┃ ┃ ┃ ┃ ┃ ┣ _utility_functions.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ compat
 ┃ ┃ ┃ ┃ ┃ ┣ tests
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_compat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_compat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ py3k.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ setup.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _inspect.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ py3k.py
 ┃ ┃ ┃ ┃ ┃ ┣ setup.py
 ┃ ┃ ┃ ┃ ┃ ┣ _inspect.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ core
 ┃ ┃ ┃ ┃ ┃ ┣ include
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ numpy
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ libdivide
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ libdivide.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ LICENSE.txt
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ random
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ bitgen.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ distributions.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ .doxyfile
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ arrayobject.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ arrayscalars.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ experimental_dtype_api.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ halffloat.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ multiarray_api.txt
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ndarrayobject.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ndarraytypes.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ noprefix.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ npy_1_7_deprecated_api.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ npy_3kcompat.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ npy_common.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ npy_cpu.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ npy_endian.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ npy_interrupt.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ npy_math.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ npy_no_deprecated_api.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ npy_os.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ numpyconfig.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ oldnumeric.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ old_defines.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ufuncobject.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ufunc_api.txt
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ utils.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _neighborhood_iterator_imp.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _numpyconfig.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __multiarray_api.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __ufunc_api.h
 ┃ ┃ ┃ ┃ ┃ ┣ lib
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ npy-pkg-config
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ mlib.ini
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ npymath.ini
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ npymath.lib
 ┃ ┃ ┃ ┃ ┃ ┣ tests
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ data
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ astype_copy.pkl
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ generate_umath_validation_data.cpp
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ recarray_from_file.fits
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ umath-validation-set-arccos.csv
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ umath-validation-set-arccosh.csv
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ umath-validation-set-arcsin.csv
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ umath-validation-set-arcsinh.csv
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ umath-validation-set-arctan.csv
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ umath-validation-set-arctanh.csv
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ umath-validation-set-cbrt.csv
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ umath-validation-set-cos.csv
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ umath-validation-set-cosh.csv
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ umath-validation-set-exp.csv
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ umath-validation-set-exp2.csv
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ umath-validation-set-expm1.csv
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ umath-validation-set-log.csv
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ umath-validation-set-log10.csv
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ umath-validation-set-log1p.csv
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ umath-validation-set-log2.csv
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ umath-validation-set-README.txt
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ umath-validation-set-sin.csv
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ umath-validation-set-sinh.csv
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ umath-validation-set-tan.csv
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ umath-validation-set-tanh.csv
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ examples
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ cython
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ setup.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ checks.pyx
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ setup.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ limited_api
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ setup.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ limited_api.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ setup.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_abc.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_api.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_argparse.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_arraymethod.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_arrayprint.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_array_coercion.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_casting_unittests.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_conversion_utils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_cpu_dispatcher.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_cpu_features.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_custom_dtypes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_cython.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_datetime.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_defchararray.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_deprecations.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_dlpack.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_dtype.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_einsum.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_errstate.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_extint128.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_function_base.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_getlimits.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_half.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_hashtable.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexerrors.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_item_selection.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_limited_api.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_longdouble.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_machar.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_memmap.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_mem_overlap.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_mem_policy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_multiarray.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_nditer.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_numeric.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_numerictypes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_overrides.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_print.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_protocols.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_records.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_regression.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_scalarbuffer.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_scalarinherit.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_scalarmath.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_scalarprint.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_scalar_ctors.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_scalar_methods.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_shape_base.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_simd.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_simd_module.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_ufunc.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_umath.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_umath_accuracy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_umath_complex.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_unicode.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__exceptions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _locales.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_abc.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_api.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_argparse.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_arraymethod.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_arrayprint.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_array_coercion.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_casting_unittests.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_conversion_utils.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_cpu_dispatcher.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_cpu_features.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_custom_dtypes.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_cython.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_datetime.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_defchararray.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_deprecations.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_dlpack.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_dtype.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_einsum.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_errstate.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_extint128.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_function_base.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_getlimits.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_half.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_hashtable.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexerrors.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_item_selection.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_limited_api.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_longdouble.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_machar.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_memmap.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_mem_overlap.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_mem_policy.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_multiarray.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_nditer.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_numeric.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_numerictypes.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_overrides.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_print.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_protocols.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_records.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_regression.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_scalarbuffer.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_scalarinherit.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_scalarmath.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_scalarprint.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_scalar_ctors.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_scalar_methods.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_shape_base.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_simd.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_simd_module.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_ufunc.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_umath.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_umath_accuracy.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_umath_complex.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_unicode.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__exceptions.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _locales.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ arrayprint.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cversions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ defchararray.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ einsumfunc.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fromnumeric.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ function_base.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ generate_numpy_api.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ getlimits.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ memmap.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ multiarray.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ numeric.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ numerictypes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ overrides.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ records.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ setup.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ setup_common.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ shape_base.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ umath.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ umath_tests.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _add_newdocs.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _add_newdocs_scalars.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _asarray.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _dtype.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _dtype_ctypes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _exceptions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _internal.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _machar.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _methods.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _string_helpers.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _type_aliases.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _ufunc_config.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ arrayprint.py
 ┃ ┃ ┃ ┃ ┃ ┣ arrayprint.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ cversions.py
 ┃ ┃ ┃ ┃ ┃ ┣ defchararray.py
 ┃ ┃ ┃ ┃ ┃ ┣ defchararray.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ einsumfunc.py
 ┃ ┃ ┃ ┃ ┃ ┣ einsumfunc.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ fromnumeric.py
 ┃ ┃ ┃ ┃ ┃ ┣ fromnumeric.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ function_base.py
 ┃ ┃ ┃ ┃ ┃ ┣ function_base.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ generate_numpy_api.py
 ┃ ┃ ┃ ┃ ┃ ┣ getlimits.py
 ┃ ┃ ┃ ┃ ┃ ┣ getlimits.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ memmap.py
 ┃ ┃ ┃ ┃ ┃ ┣ memmap.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ multiarray.py
 ┃ ┃ ┃ ┃ ┃ ┣ multiarray.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ numeric.py
 ┃ ┃ ┃ ┃ ┃ ┣ numeric.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ numerictypes.py
 ┃ ┃ ┃ ┃ ┃ ┣ numerictypes.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ overrides.py
 ┃ ┃ ┃ ┃ ┃ ┣ records.py
 ┃ ┃ ┃ ┃ ┃ ┣ records.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ setup.py
 ┃ ┃ ┃ ┃ ┃ ┣ setup_common.py
 ┃ ┃ ┃ ┃ ┃ ┣ shape_base.py
 ┃ ┃ ┃ ┃ ┃ ┣ shape_base.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ umath.py
 ┃ ┃ ┃ ┃ ┃ ┣ umath_tests.py
 ┃ ┃ ┃ ┃ ┃ ┣ _add_newdocs.py
 ┃ ┃ ┃ ┃ ┃ ┣ _add_newdocs_scalars.py
 ┃ ┃ ┃ ┃ ┃ ┣ _asarray.py
 ┃ ┃ ┃ ┃ ┃ ┣ _asarray.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ _dtype.py
 ┃ ┃ ┃ ┃ ┃ ┣ _dtype_ctypes.py
 ┃ ┃ ┃ ┃ ┃ ┣ _exceptions.py
 ┃ ┃ ┃ ┃ ┃ ┣ _internal.py
 ┃ ┃ ┃ ┃ ┃ ┣ _internal.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ _machar.py
 ┃ ┃ ┃ ┃ ┃ ┣ _methods.py
 ┃ ┃ ┃ ┃ ┃ ┣ _multiarray_tests.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ _multiarray_umath.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ _operand_flag_tests.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ _rational_tests.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ _simd.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ _string_helpers.py
 ┃ ┃ ┃ ┃ ┃ ┣ _struct_ufunc_tests.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ _type_aliases.py
 ┃ ┃ ┃ ┃ ┃ ┣ _type_aliases.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ _ufunc_config.py
 ┃ ┃ ┃ ┃ ┃ ┣ _ufunc_config.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ _umath_tests.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.pyi
 ┃ ┃ ┃ ┃ ┣ distutils
 ┃ ┃ ┃ ┃ ┃ ┣ checks
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cpu_asimd.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cpu_asimddp.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cpu_asimdfhm.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cpu_asimdhp.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cpu_avx.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cpu_avx2.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cpu_avx512cd.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cpu_avx512f.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cpu_avx512_clx.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cpu_avx512_cnl.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cpu_avx512_icl.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cpu_avx512_knl.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cpu_avx512_knm.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cpu_avx512_skx.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cpu_f16c.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cpu_fma3.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cpu_fma4.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cpu_neon.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cpu_neon_fp16.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cpu_neon_vfpv4.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cpu_popcnt.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cpu_sse.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cpu_sse2.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cpu_sse3.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cpu_sse41.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cpu_sse42.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cpu_ssse3.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cpu_vsx.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cpu_vsx2.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cpu_vsx3.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cpu_xop.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ extra_avx512bw_mask.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ extra_avx512dq_mask.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ extra_avx512f_reduce.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ extra_vsx_asm.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ test_flags.c
 ┃ ┃ ┃ ┃ ┃ ┣ command
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ autodist.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ bdist_rpm.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ build.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ build_clib.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ build_ext.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ build_py.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ build_scripts.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ build_src.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ config.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ config_compiler.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ develop.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ egg_info.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ install.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ install_clib.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ install_data.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ install_headers.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ sdist.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ autodist.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ bdist_rpm.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ build.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ build_clib.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ build_ext.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ build_py.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ build_scripts.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ build_src.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ config.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ config_compiler.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ develop.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ egg_info.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ install.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ install_clib.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ install_data.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ install_headers.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ sdist.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ fcompiler
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ absoft.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ arm.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ compaq.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ environment.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ fujitsu.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ g95.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ gnu.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hpux.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ibm.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ intel.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ lahey.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ mips.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ nag.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ none.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ nv.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pathf95.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pg.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ sun.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ vast.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ absoft.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ arm.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ compaq.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ environment.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fujitsu.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ g95.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ gnu.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hpux.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ ibm.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ intel.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ lahey.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ mips.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ nag.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ none.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ nv.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pathf95.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pg.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ sun.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ vast.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ mingw
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ gfortran_vs2003_hack.c
 ┃ ┃ ┃ ┃ ┃ ┣ tests
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_build_ext.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_ccompiler_opt.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_ccompiler_opt_conf.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_exec_command.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_fcompiler.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_fcompiler_gnu.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_fcompiler_intel.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_fcompiler_nagfor.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_from_template.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_log.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_mingw32ccompiler.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_misc_util.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_npy_pkg_config.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_shell_utils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_system_info.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_build_ext.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_ccompiler_opt.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_ccompiler_opt_conf.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_exec_command.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_fcompiler.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_fcompiler_gnu.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_fcompiler_intel.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_fcompiler_nagfor.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_from_template.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_log.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_mingw32ccompiler.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_misc_util.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_npy_pkg_config.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_shell_utils.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_system_info.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ armccompiler.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ ccompiler.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ ccompiler_opt.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ conv_template.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ core.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cpuinfo.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ exec_command.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ extension.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ from_template.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ intelccompiler.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ lib2def.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ line_endings.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ log.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ mingw32ccompiler.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ misc_util.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ msvc9compiler.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ msvccompiler.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ npy_pkg_config.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ numpy_distribution.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pathccompiler.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ setup.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ system_info.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ unixccompiler.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _shell_utils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __config__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ armccompiler.py
 ┃ ┃ ┃ ┃ ┃ ┣ ccompiler.py
 ┃ ┃ ┃ ┃ ┃ ┣ ccompiler_opt.py
 ┃ ┃ ┃ ┃ ┃ ┣ conv_template.py
 ┃ ┃ ┃ ┃ ┃ ┣ core.py
 ┃ ┃ ┃ ┃ ┃ ┣ cpuinfo.py
 ┃ ┃ ┃ ┃ ┃ ┣ exec_command.py
 ┃ ┃ ┃ ┃ ┃ ┣ extension.py
 ┃ ┃ ┃ ┃ ┃ ┣ from_template.py
 ┃ ┃ ┃ ┃ ┃ ┣ intelccompiler.py
 ┃ ┃ ┃ ┃ ┃ ┣ lib2def.py
 ┃ ┃ ┃ ┃ ┃ ┣ line_endings.py
 ┃ ┃ ┃ ┃ ┃ ┣ log.py
 ┃ ┃ ┃ ┃ ┃ ┣ mingw32ccompiler.py
 ┃ ┃ ┃ ┃ ┃ ┣ misc_util.py
 ┃ ┃ ┃ ┃ ┃ ┣ msvc9compiler.py
 ┃ ┃ ┃ ┃ ┃ ┣ msvccompiler.py
 ┃ ┃ ┃ ┃ ┃ ┣ npy_pkg_config.py
 ┃ ┃ ┃ ┃ ┃ ┣ numpy_distribution.py
 ┃ ┃ ┃ ┃ ┃ ┣ pathccompiler.py
 ┃ ┃ ┃ ┃ ┃ ┣ setup.py
 ┃ ┃ ┃ ┃ ┃ ┣ system_info.py
 ┃ ┃ ┃ ┃ ┃ ┣ unixccompiler.py
 ┃ ┃ ┃ ┃ ┃ ┣ _shell_utils.py
 ┃ ┃ ┃ ┃ ┃ ┣ __config__.py
 ┃ ┃ ┃ ┃ ┃ ┣ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.pyi
 ┃ ┃ ┃ ┃ ┣ doc
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ constants.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ ufuncs.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ constants.py
 ┃ ┃ ┃ ┃ ┃ ┣ ufuncs.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ f2py
 ┃ ┃ ┃ ┃ ┃ ┣ src
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fortranobject.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ fortranobject.h
 ┃ ┃ ┃ ┃ ┃ ┣ tests
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ src
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ array_from_pyobj
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ wrapmodule.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ assumed_shape
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ .f2py_f2cmap
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ foo_free.f90
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ foo_mod.f90
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ foo_use.f90
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ precision.f90
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ common
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ block.f
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ kind
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ foo.f90
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ mixed
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ foo.f
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ foo_fixed.f90
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ foo_free.f90
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ module_data
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ mod.mod
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ module_data_docstring.f90
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ parameter
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ constant_both.f90
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ constant_compound.f90
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ constant_integer.f90
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ constant_non_compound.f90
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ constant_real.f90
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ regression
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ inout.f90
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ size
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ foo.f90
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ string
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ char.f90
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_abstract_interface.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_array_from_pyobj.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_assumed_shape.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_block_docstring.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_callback.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_common.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_compile_function.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_crackfortran.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_kind.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_mixed.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_module_doc.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_parameter.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_quoted_character.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_regression.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_return_character.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_return_complex.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_return_integer.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_return_logical.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_return_real.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_semicolon_split.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_size.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_string.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_symbolic.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ util.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_abstract_interface.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_array_from_pyobj.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_assumed_shape.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_block_docstring.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_callback.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_common.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_compile_function.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_crackfortran.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_kind.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_mixed.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_module_doc.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_parameter.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_quoted_character.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_regression.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_return_character.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_return_complex.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_return_integer.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_return_logical.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_return_real.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_semicolon_split.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_size.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_string.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_symbolic.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ util.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ auxfuncs.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ capi_maps.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cb_rules.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cfuncs.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ common_rules.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ crackfortran.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ diagnose.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ f2py2e.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ f2py_testing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ f90mod_rules.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ func2subr.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ rules.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ setup.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ symbolic.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ use_rules.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __main__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __version__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ auxfuncs.py
 ┃ ┃ ┃ ┃ ┃ ┣ capi_maps.py
 ┃ ┃ ┃ ┃ ┃ ┣ cb_rules.py
 ┃ ┃ ┃ ┃ ┃ ┣ cfuncs.py
 ┃ ┃ ┃ ┃ ┃ ┣ common_rules.py
 ┃ ┃ ┃ ┃ ┃ ┣ crackfortran.py
 ┃ ┃ ┃ ┃ ┃ ┣ diagnose.py
 ┃ ┃ ┃ ┃ ┃ ┣ f2py2e.py
 ┃ ┃ ┃ ┃ ┃ ┣ f2py_testing.py
 ┃ ┃ ┃ ┃ ┃ ┣ f90mod_rules.py
 ┃ ┃ ┃ ┃ ┃ ┣ func2subr.py
 ┃ ┃ ┃ ┃ ┃ ┣ rules.py
 ┃ ┃ ┃ ┃ ┃ ┣ setup.py
 ┃ ┃ ┃ ┃ ┃ ┣ symbolic.py
 ┃ ┃ ┃ ┃ ┃ ┣ use_rules.py
 ┃ ┃ ┃ ┃ ┃ ┣ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ __init__.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ __main__.py
 ┃ ┃ ┃ ┃ ┃ ┗ __version__.py
 ┃ ┃ ┃ ┃ ┣ fft
 ┃ ┃ ┃ ┃ ┃ ┣ tests
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_helper.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pocketfft.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_helper.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pocketfft.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ helper.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ setup.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _pocketfft.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ helper.py
 ┃ ┃ ┃ ┃ ┃ ┣ helper.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ setup.py
 ┃ ┃ ┃ ┃ ┃ ┣ _pocketfft.py
 ┃ ┃ ┃ ┃ ┃ ┣ _pocketfft.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ _pocketfft_internal.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.pyi
 ┃ ┃ ┃ ┃ ┣ lib
 ┃ ┃ ┃ ┃ ┃ ┣ tests
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ data
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ py2-objarr.npy
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ py2-objarr.npz
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ py3-objarr.npy
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ py3-objarr.npz
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ python3.npy
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ win64python2.npy
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_arraypad.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_arraysetops.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_arrayterator.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_financial_expired.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_format.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_function_base.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_histograms.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_index_tricks.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_io.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_mixins.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_nanfunctions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_packbits.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_polynomial.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_recfunctions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_regression.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_shape_base.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_stride_tricks.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_twodim_base.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_type_check.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_ufunclike.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_utils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__datasource.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__iotools.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__version.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_arraypad.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_arraysetops.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_arrayterator.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_financial_expired.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_format.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_function_base.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_histograms.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_index_tricks.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_io.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_mixins.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_nanfunctions.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_packbits.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_polynomial.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_recfunctions.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_regression.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_shape_base.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_stride_tricks.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_twodim_base.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_type_check.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_ufunclike.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_utils.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__datasource.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__iotools.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__version.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ arraypad.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ arraysetops.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ arrayterator.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ format.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ function_base.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ histograms.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ index_tricks.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ mixins.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ nanfunctions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ npyio.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ polynomial.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ recfunctions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ scimath.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ setup.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ shape_base.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ stride_tricks.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ twodim_base.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ type_check.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ ufunclike.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ user_array.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ utils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _datasource.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _iotools.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _version.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ arraypad.py
 ┃ ┃ ┃ ┃ ┃ ┣ arraypad.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ arraysetops.py
 ┃ ┃ ┃ ┃ ┃ ┣ arraysetops.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ arrayterator.py
 ┃ ┃ ┃ ┃ ┃ ┣ arrayterator.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ format.py
 ┃ ┃ ┃ ┃ ┃ ┣ format.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ function_base.py
 ┃ ┃ ┃ ┃ ┃ ┣ function_base.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ histograms.py
 ┃ ┃ ┃ ┃ ┃ ┣ histograms.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ index_tricks.py
 ┃ ┃ ┃ ┃ ┃ ┣ index_tricks.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ mixins.py
 ┃ ┃ ┃ ┃ ┃ ┣ mixins.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ nanfunctions.py
 ┃ ┃ ┃ ┃ ┃ ┣ nanfunctions.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ npyio.py
 ┃ ┃ ┃ ┃ ┃ ┣ npyio.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ polynomial.py
 ┃ ┃ ┃ ┃ ┃ ┣ polynomial.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ recfunctions.py
 ┃ ┃ ┃ ┃ ┃ ┣ scimath.py
 ┃ ┃ ┃ ┃ ┃ ┣ scimath.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ setup.py
 ┃ ┃ ┃ ┃ ┃ ┣ shape_base.py
 ┃ ┃ ┃ ┃ ┃ ┣ shape_base.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ stride_tricks.py
 ┃ ┃ ┃ ┃ ┃ ┣ stride_tricks.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ twodim_base.py
 ┃ ┃ ┃ ┃ ┃ ┣ twodim_base.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ type_check.py
 ┃ ┃ ┃ ┃ ┃ ┣ type_check.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ ufunclike.py
 ┃ ┃ ┃ ┃ ┃ ┣ ufunclike.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ user_array.py
 ┃ ┃ ┃ ┃ ┃ ┣ utils.py
 ┃ ┃ ┃ ┃ ┃ ┣ utils.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ _datasource.py
 ┃ ┃ ┃ ┃ ┃ ┣ _iotools.py
 ┃ ┃ ┃ ┃ ┃ ┣ _version.py
 ┃ ┃ ┃ ┃ ┃ ┣ _version.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.pyi
 ┃ ┃ ┃ ┃ ┣ linalg
 ┃ ┃ ┃ ┃ ┃ ┣ tests
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_deprecations.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_linalg.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_regression.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_deprecations.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_linalg.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_regression.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ linalg.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ setup.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ lapack_lite.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ linalg.py
 ┃ ┃ ┃ ┃ ┃ ┣ linalg.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ setup.py
 ┃ ┃ ┃ ┃ ┃ ┣ _umath_linalg.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.pyi
 ┃ ┃ ┃ ┃ ┣ ma
 ┃ ┃ ┃ ┃ ┃ ┣ tests
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_core.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_deprecations.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_extras.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_mrecords.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_old_ma.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_regression.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_subclassing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_core.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_deprecations.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_extras.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_mrecords.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_old_ma.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_regression.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_subclassing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ bench.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ core.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ extras.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ mrecords.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ setup.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ testutils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ timer_comparison.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ bench.py
 ┃ ┃ ┃ ┃ ┃ ┣ core.py
 ┃ ┃ ┃ ┃ ┃ ┣ core.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ extras.py
 ┃ ┃ ┃ ┃ ┃ ┣ extras.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ mrecords.py
 ┃ ┃ ┃ ┃ ┃ ┣ mrecords.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ setup.py
 ┃ ┃ ┃ ┃ ┃ ┣ testutils.py
 ┃ ┃ ┃ ┃ ┃ ┣ timer_comparison.py
 ┃ ┃ ┃ ┃ ┃ ┣ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.pyi
 ┃ ┃ ┃ ┃ ┣ matrixlib
 ┃ ┃ ┃ ┃ ┃ ┣ tests
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_defmatrix.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_interaction.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_masked_matrix.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_matrix_linalg.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_multiarray.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_numeric.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_regression.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_defmatrix.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_interaction.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_masked_matrix.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_matrix_linalg.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_multiarray.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_numeric.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_regression.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ defmatrix.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ setup.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ defmatrix.py
 ┃ ┃ ┃ ┃ ┃ ┣ defmatrix.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ setup.py
 ┃ ┃ ┃ ┃ ┃ ┣ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.pyi
 ┃ ┃ ┃ ┃ ┣ polynomial
 ┃ ┃ ┃ ┃ ┃ ┣ tests
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_chebyshev.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_classes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_hermite.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_hermite_e.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_laguerre.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_legendre.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_polynomial.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_polyutils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_printing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_chebyshev.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_classes.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_hermite.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_hermite_e.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_laguerre.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_legendre.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_polynomial.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_polyutils.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_printing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ chebyshev.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hermite.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hermite_e.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ laguerre.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ legendre.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ polynomial.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ polyutils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ setup.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _polybase.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ chebyshev.py
 ┃ ┃ ┃ ┃ ┃ ┣ chebyshev.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ hermite.py
 ┃ ┃ ┃ ┃ ┃ ┣ hermite.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ hermite_e.py
 ┃ ┃ ┃ ┃ ┃ ┣ hermite_e.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ laguerre.py
 ┃ ┃ ┃ ┃ ┃ ┣ laguerre.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ legendre.py
 ┃ ┃ ┃ ┃ ┃ ┣ legendre.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ polynomial.py
 ┃ ┃ ┃ ┃ ┃ ┣ polynomial.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ polyutils.py
 ┃ ┃ ┃ ┃ ┃ ┣ polyutils.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ setup.py
 ┃ ┃ ┃ ┃ ┃ ┣ _polybase.py
 ┃ ┃ ┃ ┃ ┃ ┣ _polybase.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.pyi
 ┃ ┃ ┃ ┃ ┣ random
 ┃ ┃ ┃ ┃ ┃ ┣ lib
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ npyrandom.lib
 ┃ ┃ ┃ ┃ ┃ ┣ tests
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ data
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ mt19937-testset-1.csv
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ mt19937-testset-2.csv
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pcg64-testset-1.csv
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pcg64-testset-2.csv
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pcg64dxsm-testset-1.csv
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pcg64dxsm-testset-2.csv
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ philox-testset-1.csv
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ philox-testset-2.csv
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ sfc64-testset-1.csv
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ sfc64-testset-2.csv
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_direct.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_extending.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_generator_mt19937.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_generator_mt19937_regressions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_random.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_randomstate.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_randomstate_regression.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_regression.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_seed_sequence.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_smoke.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_direct.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_extending.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_generator_mt19937.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_generator_mt19937_regressions.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_random.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_randomstate.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_randomstate_regression.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_regression.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_seed_sequence.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_smoke.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ _examples
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cffi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ extending.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ parse.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ extending.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ parse.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cython
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ setup.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ extending.pyx
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ extending_distributions.pyx
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ setup.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ numba
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ extending.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ extending_distributions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ extending.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ extending_distributions.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ setup.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _pickle.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ bit_generator.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ bit_generator.pxd
 ┃ ┃ ┃ ┃ ┃ ┣ bit_generator.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ c_distributions.pxd
 ┃ ┃ ┃ ┃ ┃ ┣ mtrand.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ mtrand.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ setup.py
 ┃ ┃ ┃ ┃ ┃ ┣ _bounded_integers.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ _bounded_integers.pxd
 ┃ ┃ ┃ ┃ ┃ ┣ _common.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ _common.pxd
 ┃ ┃ ┃ ┃ ┃ ┣ _generator.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ _generator.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ _mt19937.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ _mt19937.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ _pcg64.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ _pcg64.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ _philox.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ _philox.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ _pickle.py
 ┃ ┃ ┃ ┃ ┃ ┣ _sfc64.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ _sfc64.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ __init__.pxd
 ┃ ┃ ┃ ┃ ┃ ┣ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.pyi
 ┃ ┃ ┃ ┃ ┣ testing
 ┃ ┃ ┃ ┃ ┃ ┣ tests
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_doctesting.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_utils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_doctesting.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_utils.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ _private
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ decorators.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ extbuild.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ noseclasses.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ nosetester.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ parameterized.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ utils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ decorators.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ extbuild.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ noseclasses.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ nosetester.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ parameterized.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ utils.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ utils.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ print_coercion_tables.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ setup.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ utils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ print_coercion_tables.py
 ┃ ┃ ┃ ┃ ┃ ┣ setup.py
 ┃ ┃ ┃ ┃ ┃ ┣ utils.py
 ┃ ┃ ┃ ┃ ┃ ┣ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.pyi
 ┃ ┃ ┃ ┃ ┣ tests
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_ctypeslib.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_matlib.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_numpy_version.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_public_api.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reloading.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_scripts.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_warnings.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test__all__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ test_ctypeslib.py
 ┃ ┃ ┃ ┃ ┃ ┣ test_matlib.py
 ┃ ┃ ┃ ┃ ┃ ┣ test_numpy_version.py
 ┃ ┃ ┃ ┃ ┃ ┣ test_public_api.py
 ┃ ┃ ┃ ┃ ┃ ┣ test_reloading.py
 ┃ ┃ ┃ ┃ ┃ ┣ test_scripts.py
 ┃ ┃ ┃ ┃ ┃ ┣ test_warnings.py
 ┃ ┃ ┃ ┃ ┃ ┣ test__all__.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ typing
 ┃ ┃ ┃ ┃ ┃ ┣ tests
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ data
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ fail
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ arithmetic.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ arrayprint.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ arrayterator.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ array_constructors.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ array_like.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ array_pad.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ bitwise_ops.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ char.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ chararray.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ comparisons.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ constants.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ datasource.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ dtype.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ einsumfunc.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ flatiter.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ fromnumeric.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ histograms.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ index_tricks.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ lib_function_base.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ lib_polynomial.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ lib_utils.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ lib_version.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ linalg.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ memmap.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ modules.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ multiarray.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ndarray.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ndarray_misc.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ nditer.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ nested_sequence.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ npyio.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ numerictypes.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ random.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ rec.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ scalars.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ shape_base.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ stride_tricks.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ testing.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ twodim_base.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ type_check.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ufunclike.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ufuncs.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ufunc_config.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ warnings_and_errors.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ misc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ extended_precision.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pass
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ arithmetic.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ arrayprint.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ arrayterator.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ array_constructors.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ array_like.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ bitwise_ops.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ comparisons.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ dtype.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ einsumfunc.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ flatiter.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ fromnumeric.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ index_tricks.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ lib_utils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ lib_version.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ literal.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ mod.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ modules.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ multiarray.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ndarray_conversion.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ndarray_misc.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ndarray_shape_manipulation.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ numeric.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ numerictypes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ random.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ scalars.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ simple.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ simple_py3.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ufunclike.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ufuncs.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ufunc_config.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ warnings_and_errors.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ arithmetic.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ arrayprint.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ arrayterator.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ array_constructors.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ array_like.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ bitwise_ops.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ comparisons.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ dtype.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ einsumfunc.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ flatiter.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ fromnumeric.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ index_tricks.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ lib_utils.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ lib_version.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ literal.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ mod.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ modules.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ multiarray.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ndarray_conversion.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ndarray_misc.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ndarray_shape_manipulation.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ numeric.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ numerictypes.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ random.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ scalars.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ simple.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ simple_py3.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ufunclike.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ufuncs.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ufunc_config.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ warnings_and_errors.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ reveal
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ arithmetic.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ arraypad.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ arrayprint.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ arraysetops.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ arrayterator.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ array_constructors.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ bitwise_ops.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ char.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ chararray.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ comparisons.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ constants.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ctypeslib.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ datasource.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ dtype.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ einsumfunc.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ fft.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ flatiter.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ fromnumeric.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ getlimits.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ histograms.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ index_tricks.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ lib_function_base.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ lib_polynomial.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ lib_utils.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ lib_version.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ linalg.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ matrix.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ memmap.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ mod.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ modules.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ multiarray.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ nbit_base_example.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ndarray_conversion.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ndarray_misc.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ndarray_shape_manipulation.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ nditer.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ nested_sequence.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ npyio.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ numeric.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ numerictypes.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ random.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ rec.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ scalars.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ shape_base.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ stride_tricks.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ testing.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ twodim_base.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ type_check.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ufunclike.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ufuncs.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ufunc_config.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ version.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ warnings_and_errors.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ mypy.ini
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_generic_alias.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_isfile.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_runtime.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_typing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_generic_alias.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_isfile.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_runtime.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_typing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ mypy_plugin.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ setup.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _add_docstring.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _array_like.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _char_codes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _dtype_like.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _extended_precision.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _generic_alias.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _nbit.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _nested_sequence.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _scalars.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _shape.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ mypy_plugin.py
 ┃ ┃ ┃ ┃ ┃ ┣ setup.py
 ┃ ┃ ┃ ┃ ┃ ┣ _add_docstring.py
 ┃ ┃ ┃ ┃ ┃ ┣ _array_like.py
 ┃ ┃ ┃ ┃ ┃ ┣ _callable.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ _char_codes.py
 ┃ ┃ ┃ ┃ ┃ ┣ _dtype_like.py
 ┃ ┃ ┃ ┃ ┃ ┣ _extended_precision.py
 ┃ ┃ ┃ ┃ ┃ ┣ _generic_alias.py
 ┃ ┃ ┃ ┃ ┃ ┣ _nbit.py
 ┃ ┃ ┃ ┃ ┃ ┣ _nested_sequence.py
 ┃ ┃ ┃ ┃ ┃ ┣ _scalars.py
 ┃ ┃ ┃ ┃ ┃ ┣ _shape.py
 ┃ ┃ ┃ ┃ ┃ ┣ _ufunc.pyi
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┣ conftest.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ ctypeslib.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ dual.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ matlib.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ setup.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ version.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _distributor_init.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _globals.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _pytesttester.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _version.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ __config__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┣ conftest.py
 ┃ ┃ ┃ ┃ ┣ ctypeslib.py
 ┃ ┃ ┃ ┃ ┣ ctypeslib.pyi
 ┃ ┃ ┃ ┃ ┣ dual.py
 ┃ ┃ ┃ ┃ ┣ LICENSE.txt
 ┃ ┃ ┃ ┃ ┣ matlib.py
 ┃ ┃ ┃ ┃ ┣ py.typed
 ┃ ┃ ┃ ┃ ┣ setup.py
 ┃ ┃ ┃ ┃ ┣ version.py
 ┃ ┃ ┃ ┃ ┣ _distributor_init.py
 ┃ ┃ ┃ ┃ ┣ _globals.py
 ┃ ┃ ┃ ┃ ┣ _pytesttester.py
 ┃ ┃ ┃ ┃ ┣ _pytesttester.pyi
 ┃ ┃ ┃ ┃ ┣ _version.py
 ┃ ┃ ┃ ┃ ┣ __config__.py
 ┃ ┃ ┃ ┃ ┣ __init__.cython-30.pxd
 ┃ ┃ ┃ ┃ ┣ __init__.pxd
 ┃ ┃ ┃ ┃ ┣ __init__.py
 ┃ ┃ ┃ ┃ ┗ __init__.pyi
 ┃ ┃ ┃ ┣ numpy-1.22.2.dist-info
 ┃ ┃ ┃ ┃ ┣ entry_points.txt
 ┃ ┃ ┃ ┃ ┣ INSTALLER
 ┃ ┃ ┃ ┃ ┣ LICENSE.txt
 ┃ ┃ ┃ ┃ ┣ LICENSES_bundled.txt
 ┃ ┃ ┃ ┃ ┣ METADATA
 ┃ ┃ ┃ ┃ ┣ RECORD
 ┃ ┃ ┃ ┃ ┣ REQUESTED
 ┃ ┃ ┃ ┃ ┣ top_level.txt
 ┃ ┃ ┃ ┃ ┗ WHEEL
 ┃ ┃ ┃ ┣ opencv_python-4.5.5.62.dist-info
 ┃ ┃ ┃ ┃ ┣ INSTALLER
 ┃ ┃ ┃ ┃ ┣ LICENSE-3RD-PARTY.txt
 ┃ ┃ ┃ ┃ ┣ LICENSE.txt
 ┃ ┃ ┃ ┃ ┣ METADATA
 ┃ ┃ ┃ ┃ ┣ RECORD
 ┃ ┃ ┃ ┃ ┣ REQUESTED
 ┃ ┃ ┃ ┃ ┣ top_level.txt
 ┃ ┃ ┃ ┃ ┗ WHEEL
 ┃ ┃ ┃ ┣ ordlookup
 ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┣ oleaut32.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ ws2_32.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┣ oleaut32.py
 ┃ ┃ ┃ ┃ ┣ ws2_32.py
 ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┣ pandas
 ┃ ┃ ┃ ┃ ┣ api
 ┃ ┃ ┃ ┃ ┃ ┣ extensions
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ indexers
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ types
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ arrays
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ compat
 ┃ ┃ ┃ ┃ ┃ ┣ numpy
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ function.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ function.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ chainmap.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pickle_compat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyarrow.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _optional.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ chainmap.py
 ┃ ┃ ┃ ┃ ┃ ┣ pickle_compat.py
 ┃ ┃ ┃ ┃ ┃ ┣ pyarrow.py
 ┃ ┃ ┃ ┃ ┃ ┣ _optional.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ core
 ┃ ┃ ┃ ┃ ┃ ┣ arrays
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ sparse
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ accessor.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ array.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ dtype.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ scipy_sparse.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ accessor.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ array.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ dtype.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ scipy_sparse.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ base.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ boolean.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ categorical.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ datetimelike.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ datetimes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ floating.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ integer.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ interval.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ masked.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ numeric.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ numpy_.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ period.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ string_.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ string_arrow.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ timedeltas.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _arrow_utils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _mixins.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _ranges.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ base.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ boolean.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ categorical.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ datetimelike.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ datetimes.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ floating.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ integer.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ interval.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ masked.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ numeric.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ numpy_.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ period.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ string_.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ string_arrow.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ timedeltas.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _arrow_utils.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _mixins.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _ranges.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ array_algos
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ masked_reductions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ putmask.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ quantile.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ replace.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ take.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ transforms.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ masked_reductions.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ putmask.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ quantile.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ replace.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ take.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ transforms.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ computation
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ align.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ api.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ check.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ common.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ engines.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ eval.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ expr.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ expressions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ops.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ parsing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pytables.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ scope.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ align.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ api.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ check.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ common.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ engines.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ eval.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ expr.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ expressions.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ ops.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ parsing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pytables.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ scope.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ dtypes
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ api.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ base.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ cast.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ common.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ concat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ dtypes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ generic.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ inference.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ missing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ api.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ base.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cast.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ common.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ concat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ dtypes.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ generic.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ inference.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ missing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ groupby
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ base.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ categorical.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ generic.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ groupby.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ grouper.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ indexing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ numba_.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ops.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ base.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ categorical.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ generic.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ groupby.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ grouper.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ indexing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ numba_.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ ops.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ indexers
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ objects.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ utils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ objects.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ utils.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ indexes
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ accessors.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ api.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ base.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ category.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ datetimelike.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ datetimes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ extension.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ frozen.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ interval.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ multi.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ numeric.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ period.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ range.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ timedeltas.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ accessors.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ api.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ base.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ category.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ datetimelike.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ datetimes.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ extension.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ frozen.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ interval.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ multi.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ numeric.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ period.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ range.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ timedeltas.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ internals
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ api.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ array_manager.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ base.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ blocks.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ concat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ construction.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ managers.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ops.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ api.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ array_manager.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ base.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ blocks.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ concat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ construction.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ managers.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ ops.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ ops
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ array_ops.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ common.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ dispatch.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ docstrings.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ invalid.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ mask_ops.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ methods.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ missing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ array_ops.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ common.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ dispatch.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ docstrings.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ invalid.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ mask_ops.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ methods.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ missing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ reshape
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ api.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ concat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ melt.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ merge.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pivot.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ reshape.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ tile.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ util.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ api.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ concat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ melt.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ merge.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pivot.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ reshape.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ tile.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ util.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ sparse
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ api.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ api.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ strings
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ accessor.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ base.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ object_array.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ accessor.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ base.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ object_array.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ tools
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ datetimes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ numeric.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ timedeltas.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ times.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ datetimes.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ numeric.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ timedeltas.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ times.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ util
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hashing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ numba_.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hashing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ numba_.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ window
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ common.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ doc.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ewm.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ expanding.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ numba_.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ online.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ rolling.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ common.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ doc.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ ewm.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ expanding.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ numba_.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ online.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ rolling.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ _numba
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ kernels
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ mean_.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ min_max_.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ shared.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ sum_.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ var_.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ mean_.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ min_max_.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ shared.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ sum_.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ var_.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ executor.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ executor.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ accessor.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ algorithms.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ api.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ apply.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ arraylike.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ base.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ common.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ config_init.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ construction.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ describe.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ flags.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ frame.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ generic.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ index.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ indexing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ missing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ nanops.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ resample.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ roperator.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ sample.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ series.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ shared_docs.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ sorting.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ accessor.py
 ┃ ┃ ┃ ┃ ┃ ┣ algorithms.py
 ┃ ┃ ┃ ┃ ┃ ┣ api.py
 ┃ ┃ ┃ ┃ ┃ ┣ apply.py
 ┃ ┃ ┃ ┃ ┃ ┣ arraylike.py
 ┃ ┃ ┃ ┃ ┃ ┣ base.py
 ┃ ┃ ┃ ┃ ┃ ┣ common.py
 ┃ ┃ ┃ ┃ ┃ ┣ config_init.py
 ┃ ┃ ┃ ┃ ┃ ┣ construction.py
 ┃ ┃ ┃ ┃ ┃ ┣ describe.py
 ┃ ┃ ┃ ┃ ┃ ┣ flags.py
 ┃ ┃ ┃ ┃ ┃ ┣ frame.py
 ┃ ┃ ┃ ┃ ┃ ┣ generic.py
 ┃ ┃ ┃ ┃ ┃ ┣ index.py
 ┃ ┃ ┃ ┃ ┃ ┣ indexing.py
 ┃ ┃ ┃ ┃ ┃ ┣ missing.py
 ┃ ┃ ┃ ┃ ┃ ┣ nanops.py
 ┃ ┃ ┃ ┃ ┃ ┣ resample.py
 ┃ ┃ ┃ ┃ ┃ ┣ roperator.py
 ┃ ┃ ┃ ┃ ┃ ┣ sample.py
 ┃ ┃ ┃ ┃ ┃ ┣ series.py
 ┃ ┃ ┃ ┃ ┃ ┣ shared_docs.py
 ┃ ┃ ┃ ┃ ┃ ┣ sorting.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ errors
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ io
 ┃ ┃ ┃ ┃ ┃ ┣ clipboard
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ excel
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _base.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _odfreader.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _odswriter.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _openpyxl.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _pyxlsb.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _util.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _xlrd.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _xlsxwriter.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _xlwt.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _base.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _odfreader.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _odswriter.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _openpyxl.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _pyxlsb.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _util.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _xlrd.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _xlsxwriter.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _xlwt.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ formats
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ templates
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ html.tpl
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ html_style.tpl
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ html_table.tpl
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ latex.tpl
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ latex_longtable.tpl
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ latex_table.tpl
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ console.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ css.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ csvs.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ excel.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ format.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ html.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ info.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ latex.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ printing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ string.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ style.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ style_render.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ xml.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _color_data.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ console.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ css.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ csvs.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ excel.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ format.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ html.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ info.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ latex.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ printing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ string.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ style.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ style_render.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ xml.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _color_data.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ json
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _json.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _normalize.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _table_schema.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _json.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _normalize.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _table_schema.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ parsers
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ arrow_parser_wrapper.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ base_parser.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ c_parser_wrapper.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ python_parser.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ readers.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ arrow_parser_wrapper.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ base_parser.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ c_parser_wrapper.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ python_parser.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ readers.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ sas
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ sas7bdat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ sasreader.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ sas_constants.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ sas_xport.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ sas.pyx
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ sas7bdat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ sasreader.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ sas_constants.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ sas_xport.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _sas.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ api.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ clipboards.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ common.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ date_converters.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ feather_format.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ gbq.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ html.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ orc.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ parquet.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pickle.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pytables.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ spss.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ sql.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ stata.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ xml.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ api.py
 ┃ ┃ ┃ ┃ ┃ ┣ clipboards.py
 ┃ ┃ ┃ ┃ ┃ ┣ common.py
 ┃ ┃ ┃ ┃ ┃ ┣ date_converters.py
 ┃ ┃ ┃ ┃ ┃ ┣ feather_format.py
 ┃ ┃ ┃ ┃ ┃ ┣ gbq.py
 ┃ ┃ ┃ ┃ ┃ ┣ html.py
 ┃ ┃ ┃ ┃ ┃ ┣ orc.py
 ┃ ┃ ┃ ┃ ┃ ┣ parquet.py
 ┃ ┃ ┃ ┃ ┃ ┣ pickle.py
 ┃ ┃ ┃ ┃ ┃ ┣ pytables.py
 ┃ ┃ ┃ ┃ ┃ ┣ spss.py
 ┃ ┃ ┃ ┃ ┃ ┣ sql.py
 ┃ ┃ ┃ ┃ ┃ ┣ stata.py
 ┃ ┃ ┃ ┃ ┃ ┣ xml.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ plotting
 ┃ ┃ ┃ ┃ ┃ ┣ _matplotlib
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ boxplot.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ compat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ converter.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ core.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ groupby.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hist.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ misc.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ style.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ timeseries.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ tools.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ boxplot.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ compat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ converter.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ core.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ groupby.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hist.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ misc.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ style.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ timeseries.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ tools.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _core.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _misc.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _core.py
 ┃ ┃ ┃ ┃ ┃ ┣ _misc.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ tests
 ┃ ┃ ┃ ┃ ┃ ┣ api
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_api.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_types.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_api.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_types.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ apply
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ common.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_frame_apply.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_frame_apply_relabeling.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_frame_transform.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_invalid_arg.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_series_apply.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_series_apply_relabeling.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_series_transform.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_str.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ common.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_frame_apply.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_frame_apply_relabeling.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_frame_transform.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_invalid_arg.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_series_apply.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_series_apply_relabeling.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_series_transform.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_str.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ arithmetic
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ common.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_array_ops.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_categorical.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_datetime64.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_interval.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_numeric.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_object.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_period.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_timedelta64.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ common.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_array_ops.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_categorical.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_datetime64.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_interval.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_numeric.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_object.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_period.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_timedelta64.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ arrays
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ boolean
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_arithmetic.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_astype.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_comparison.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_construction.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_function.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_logical.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_ops.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reduction.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_repr.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_arithmetic.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_astype.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_comparison.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_construction.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_function.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_logical.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_ops.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reduction.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_repr.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ categorical
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ common.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_algos.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_analytics.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_api.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_astype.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_constructors.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_dtypes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_missing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_operators.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_replace.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_repr.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_sorting.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_subclass.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_take.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_warnings.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ common.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_algos.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_analytics.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_api.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_astype.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_constructors.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_dtypes.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_missing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_operators.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_replace.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_repr.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_sorting.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_subclass.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_take.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_warnings.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ datetimes
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_constructors.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reductions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_constructors.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reductions.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ floating
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_arithmetic.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_astype.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_comparison.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_concat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_construction.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_function.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_repr.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_numpy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_arithmetic.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_astype.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_comparison.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_concat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_construction.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_function.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_repr.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_numpy.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ integer
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_arithmetic.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_comparison.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_concat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_construction.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_dtypes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_function.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_repr.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_arithmetic.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_comparison.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_concat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_construction.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_dtypes.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_function.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_repr.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ interval
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_astype.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_interval.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_ops.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_astype.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_interval.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_ops.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ masked
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_arithmetic.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_arrow_compat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_function.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_arithmetic.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_arrow_compat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_function.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ period
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_arrow_compat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_astype.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_constructors.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reductions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_arrow_compat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_astype.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_constructors.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reductions.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ sparse
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_accessor.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_arithmetics.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_array.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_combine_concat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_dtype.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_libsparse.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_accessor.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_arithmetics.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_array.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_combine_concat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_dtype.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_libsparse.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ string_
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_string.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_string_arrow.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_string.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_string_arrow.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ timedeltas
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_constructors.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reductions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_constructors.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reductions.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ masked_shared.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_array.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_datetimelike.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_datetimes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_ndarray_backed.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_numpy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_period.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_timedeltas.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ masked_shared.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_array.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_datetimelike.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_datetimes.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_ndarray_backed.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_numpy.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_period.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_timedeltas.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ base
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ common.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_constructors.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_conversion.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_fillna.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_misc.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_transpose.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_unique.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_value_counts.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ common.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_constructors.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_conversion.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_fillna.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_misc.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_transpose.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_unique.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_value_counts.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ computation
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_compat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_eval.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_compat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_eval.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ config
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_config.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_localization.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_config.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_localization.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ construction
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_extract_array.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_extract_array.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ dtypes
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cast
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_can_hold_element.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_construct_from_scalar.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_construct_ndarray.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_construct_object_arr.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_dict_compat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_downcast.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_find_common_type.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_infer_datetimelike.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_infer_dtype.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_maybe_box_native.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_promote.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_can_hold_element.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_construct_from_scalar.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_construct_ndarray.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_construct_object_arr.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_dict_compat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_downcast.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_find_common_type.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_infer_datetimelike.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_infer_dtype.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_maybe_box_native.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_promote.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_common.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_concat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_dtypes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_generic.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_inference.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_missing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_common.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_concat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_dtypes.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_generic.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_inference.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_missing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ extension
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ arrow
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ arrays.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_bool.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_string.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_timestamp.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ arrays.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_bool.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_string.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_timestamp.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ base
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ base.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ casting.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ constructors.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ dim2.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ dtype.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ getitem.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ groupby.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ index.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ interface.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ io.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ methods.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ missing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ops.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ printing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ reduce.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ reshaping.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ setitem.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ base.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ casting.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ constructors.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ dim2.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ dtype.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ getitem.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ groupby.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ index.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ interface.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ io.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ methods.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ missing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ops.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ printing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ reduce.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ reshaping.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ setitem.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ date
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ array.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ array.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ decimal
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ array.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_decimal.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ array.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_decimal.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ json
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ array.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_json.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ array.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_json.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ list
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ array.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_list.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ array.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_list.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_boolean.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_categorical.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_common.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_datetime.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_extension.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_external_block.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_floating.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_integer.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_interval.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_numpy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_period.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_sparse.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_string.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_boolean.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_categorical.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_common.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_datetime.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_extension.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_external_block.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_floating.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_integer.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_interval.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_numpy.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_period.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_sparse.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_string.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ frame
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ constructors
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_from_dict.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_from_records.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_from_dict.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_from_records.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ indexing
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_delitem.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_get.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_getitem.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_get_value.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_insert.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_lookup.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_mask.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_setitem.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_set_value.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_take.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_where.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_xs.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_delitem.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_get.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_getitem.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_get_value.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_insert.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_lookup.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_mask.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_setitem.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_set_value.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_take.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_where.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_xs.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ methods
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_add_prefix_suffix.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_align.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_append.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_asfreq.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_asof.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_assign.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_astype.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_at_time.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_between_time.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_clip.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_combine.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_combine_first.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_compare.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_convert.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_convert_dtypes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_copy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_count.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_count_with_level_deprecated.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_cov_corr.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_describe.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_diff.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_dot.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_drop.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_droplevel.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_dropna.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_drop_duplicates.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_dtypes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_duplicated.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_equals.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_explode.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_fillna.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_filter.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_first_and_last.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_first_valid_index.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_get_numeric_data.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_head_tail.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_infer_objects.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_interpolate.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_isin.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_is_homogeneous_dtype.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_join.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_matmul.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_nlargest.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pct_change.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pipe.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pop.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_quantile.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_rank.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reindex.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reindex_like.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_rename.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_rename_axis.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reorder_levels.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_replace.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reset_index.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_round.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_sample.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_select_dtypes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_set_axis.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_set_index.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_shift.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_sort_index.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_sort_values.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_swapaxes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_swaplevel.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_csv.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_dict.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_dict_of_blocks.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_numpy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_period.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_records.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_timestamp.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_transpose.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_truncate.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_tz_convert.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_tz_localize.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_update.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_values.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_value_counts.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_add_prefix_suffix.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_align.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_append.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_asfreq.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_asof.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_assign.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_astype.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_at_time.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_between_time.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_clip.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_combine.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_combine_first.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_compare.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_convert.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_convert_dtypes.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_copy.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_count.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_count_with_level_deprecated.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_cov_corr.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_describe.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_diff.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_dot.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_drop.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_droplevel.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_dropna.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_drop_duplicates.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_dtypes.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_duplicated.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_equals.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_explode.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_fillna.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_filter.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_first_and_last.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_first_valid_index.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_get_numeric_data.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_head_tail.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_infer_objects.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_interpolate.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_isin.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_is_homogeneous_dtype.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_join.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_matmul.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_nlargest.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pct_change.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pipe.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pop.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_quantile.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_rank.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reindex.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reindex_like.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_rename.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_rename_axis.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reorder_levels.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_replace.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reset_index.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_round.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_sample.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_select_dtypes.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_set_axis.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_set_index.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_shift.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_sort_index.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_sort_values.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_swapaxes.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_swaplevel.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_csv.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_dict.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_dict_of_blocks.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_numpy.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_period.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_records.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_timestamp.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_transpose.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_truncate.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_tz_convert.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_tz_localize.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_update.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_values.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_value_counts.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ common.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_alter_axes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_api.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_arithmetic.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_block_internals.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_constructors.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_cumulative.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_iteration.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_logical_ops.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_nonunique_indexes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_npfuncs.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_query_eval.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reductions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_repr_info.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_stack_unstack.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_subclass.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_ufunc.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_unary.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_validate.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ common.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_alter_axes.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_api.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_arithmetic.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_block_internals.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_constructors.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_cumulative.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_iteration.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_logical_ops.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_nonunique_indexes.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_npfuncs.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_query_eval.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reductions.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_repr_info.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_stack_unstack.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_subclass.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_ufunc.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_unary.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_validate.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ generic
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_duplicate_labels.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_finalize.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_frame.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_generic.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_label_or_level_utils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_series.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_xarray.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_duplicate_labels.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_finalize.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_frame.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_generic.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_label_or_level_utils.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_series.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_xarray.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ groupby
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ aggregate
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_aggregate.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_cython.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_numba.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_other.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_aggregate.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_cython.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_numba.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_other.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ transform
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_numba.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_transform.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_numba.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_transform.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_allowlist.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_any_all.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_apply.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_apply_mutate.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_bin_groupby.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_categorical.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_counting.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_filters.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_frame_value_counts.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_function.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_groupby.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_groupby_dropna.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_groupby_shift_diff.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_groupby_subclass.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_grouping.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_index_as_string.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_libgroupby.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_min_max.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_missing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_nth.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_numba.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_nunique.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pipe.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_quantile.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_rank.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_sample.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_size.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_timegrouper.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_value_counts.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_allowlist.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_any_all.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_apply.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_apply_mutate.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_bin_groupby.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_categorical.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_counting.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_filters.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_frame_value_counts.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_function.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_groupby.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_groupby_dropna.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_groupby_shift_diff.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_groupby_subclass.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_grouping.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_index_as_string.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_libgroupby.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_min_max.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_missing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_nth.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_numba.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_nunique.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pipe.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_quantile.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_rank.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_sample.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_size.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_timegrouper.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_value_counts.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ indexes
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ base_class
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_constructors.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_formats.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pickle.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reshape.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_setops.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_where.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_constructors.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_formats.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pickle.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reshape.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_setops.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_where.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ categorical
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_append.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_astype.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_category.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_constructors.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_equals.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_fillna.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_formats.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_map.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reindex.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_append.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_astype.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_category.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_constructors.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_equals.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_fillna.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_formats.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_map.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reindex.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ datetimelike_
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_drop_duplicates.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_equals.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_is_monotonic.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_nat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_sort_values.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_value_counts.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_drop_duplicates.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_equals.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_is_monotonic.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_nat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_sort_values.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_value_counts.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ datetimes
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ methods
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_astype.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_factorize.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_fillna.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_insert.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_isocalendar.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_repeat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_shift.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_snap.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_frame.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_period.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_series.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_astype.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_factorize.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_fillna.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_insert.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_isocalendar.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_repeat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_shift.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_snap.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_frame.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_period.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_series.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_asof.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_constructors.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_datetime.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_datetimelike.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_date_range.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_delete.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_formats.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_freq_attr.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_join.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_map.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_misc.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_npfuncs.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_ops.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_partial_slicing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pickle.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reindex.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_scalar_compat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_setops.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_timezones.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_unique.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_asof.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_constructors.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_datetime.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_datetimelike.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_date_range.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_delete.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_formats.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_freq_attr.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_join.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_map.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_misc.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_npfuncs.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_ops.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_partial_slicing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pickle.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reindex.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_scalar_compat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_setops.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_timezones.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_unique.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ interval
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_astype.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_base.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_constructors.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_equals.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_formats.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_interval.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_interval_range.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_interval_tree.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_join.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pickle.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_setops.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_astype.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_base.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_constructors.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_equals.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_formats.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_interval.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_interval_range.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_interval_tree.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_join.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pickle.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_setops.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ multi
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_analytics.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_astype.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_compat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_constructors.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_conversion.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_copy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_drop.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_duplicates.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_equivalence.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_formats.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_get_level_values.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_get_set.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_integrity.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_isin.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_join.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_lexsort.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_missing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_monotonic.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_names.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_partial_indexing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pickle.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reindex.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reshape.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_setops.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_sorting.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_take.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_analytics.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_astype.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_compat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_constructors.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_conversion.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_copy.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_drop.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_duplicates.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_equivalence.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_formats.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_get_level_values.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_get_set.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_integrity.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_isin.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_join.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_lexsort.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_missing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_monotonic.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_names.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_partial_indexing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pickle.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reindex.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reshape.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_setops.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_sorting.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_take.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ numeric
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_astype.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_join.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_numeric.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_setops.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_astype.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_join.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_numeric.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_setops.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ object
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_astype.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_astype.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ period
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ methods
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_asfreq.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_astype.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_factorize.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_fillna.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_insert.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_is_full.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_repeat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_shift.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_timestamp.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_asfreq.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_astype.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_factorize.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_fillna.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_insert.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_is_full.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_repeat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_shift.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_timestamp.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_constructors.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_formats.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_freq_attr.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_join.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_monotonic.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_partial_slicing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_period.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_period_range.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pickle.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_resolution.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_scalar_compat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_searchsorted.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_setops.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_tools.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_constructors.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_formats.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_freq_attr.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_join.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_monotonic.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_partial_slicing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_period.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_period_range.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pickle.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_resolution.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_scalar_compat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_searchsorted.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_setops.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_tools.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ ranges
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_constructors.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_join.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_range.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_setops.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_constructors.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_join.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_range.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_setops.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ timedeltas
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ methods
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_astype.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_factorize.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_fillna.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_insert.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_repeat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_shift.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_astype.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_factorize.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_fillna.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_insert.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_repeat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_shift.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_constructors.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_delete.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_formats.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_freq_attr.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_join.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_ops.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pickle.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_scalar_compat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_searchsorted.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_setops.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_timedelta.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_timedelta_range.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_constructors.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_delete.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_formats.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_freq_attr.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_join.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_ops.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pickle.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_scalar_compat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_searchsorted.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_setops.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_timedelta.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_timedelta_range.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ common.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ datetimelike.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_any_index.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_base.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_common.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_engines.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_frozen.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_index_new.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_numpy_compat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_setops.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ common.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ datetimelike.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_any_index.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_base.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_common.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_engines.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_frozen.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_index_new.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_numpy_compat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_setops.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ indexing
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ interval
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_interval.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_interval_new.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_interval.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_interval_new.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ multiindex
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_chaining_and_caching.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_datetime.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_getitem.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_iloc.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing_slow.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_loc.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_multiindex.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_partial.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_setitem.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_slice.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_sorted.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_chaining_and_caching.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_datetime.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_getitem.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_iloc.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing_slow.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_loc.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_multiindex.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_partial.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_setitem.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_slice.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_sorted.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ common.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_at.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_categorical.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_chaining_and_caching.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_check_indexer.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_coercion.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_datetime.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_floats.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_iat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_iloc.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexers.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_loc.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_na_indexing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_partial.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_scalar.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ common.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_at.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_categorical.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_chaining_and_caching.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_check_indexer.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_coercion.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_datetime.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_floats.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_iat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_iloc.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexers.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_loc.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_na_indexing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_partial.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_scalar.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ internals
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_api.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_internals.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_managers.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_api.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_internals.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_managers.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ io
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ data
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ fixed_width
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ fixed_width_format.txt
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ legacy_pickle
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 1.2.4
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ empty_frame_v1_2_4-GH#42345.pkl
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ parquet
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ simple.parquet
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pickle
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_mi_py27.pkl
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ test_py27.pkl
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ xml
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ baby_names.xml
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ books.xml
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ cta_rail_lines.kml
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ flatten_doc.xsl
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ row_field_output.xsl
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ gbq_fake_job.txt
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ excel
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_odf.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_odswriter.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_openpyxl.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_readers.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_style.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_writers.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_xlrd.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_xlsxwriter.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_xlwt.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_odf.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_odswriter.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_openpyxl.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_readers.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_style.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_writers.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_xlrd.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_xlsxwriter.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_xlwt.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ formats
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ style
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_bar.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_deprecated.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_format.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_highlight.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_html.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_matplotlib.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_non_unique.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_style.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_tooltip.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_latex.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_bar.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_deprecated.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_format.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_highlight.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_html.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_matplotlib.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_non_unique.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_style.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_tooltip.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_latex.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_console.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_css.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_eng_formatting.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_format.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_info.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_printing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_series_info.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_csv.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_excel.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_html.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_latex.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_markdown.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_string.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_console.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_css.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_eng_formatting.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_format.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_info.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_printing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_series_info.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_csv.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_excel.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_html.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_latex.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_markdown.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_string.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ json
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_compression.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_deprecated_kwargs.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_json_table_schema.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_json_table_schema_ext_dtype.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_normalize.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pandas.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_readlines.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_ujson.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_compression.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_deprecated_kwargs.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_json_table_schema.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_json_table_schema_ext_dtype.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_normalize.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pandas.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_readlines.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_ujson.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ parser
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ common
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_chunksize.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_common_basic.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_data_list.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_decimal.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_file_buffer_url.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_float.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_index.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_inf.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_ints.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_iterator.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_read_errors.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_verbose.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_chunksize.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_common_basic.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_data_list.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_decimal.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_file_buffer_url.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_float.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_index.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_inf.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_ints.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_iterator.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_read_errors.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_verbose.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ dtypes
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_categorical.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_dtypes_basic.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_empty.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_categorical.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_dtypes_basic.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_empty.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ usecols
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_parse_dates.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_strings.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_usecols_basic.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_parse_dates.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_strings.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_usecols_basic.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_comment.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_compression.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_converters.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_c_parser_only.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_dialect.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_encoding.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_header.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_index_col.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_mangle_dupes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_multi_thread.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_na_values.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_network.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_parse_dates.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_python_parser_only.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_quoting.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_read_fwf.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_skiprows.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_textreader.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_unsupported.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_comment.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_compression.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_converters.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_c_parser_only.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_dialect.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_encoding.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_header.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_index_col.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_mangle_dupes.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_multi_thread.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_na_values.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_network.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_parse_dates.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_python_parser_only.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_quoting.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_read_fwf.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_skiprows.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_textreader.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_unsupported.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pytables
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ common.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_append.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_categorical.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_compat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_complex.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_errors.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_file_handling.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_keys.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_put.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pytables_missing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_read.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_retain_attributes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_round_trip.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_select.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_store.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_subclass.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_timezones.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_time_series.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ common.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_append.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_categorical.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_compat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_complex.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_errors.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_file_handling.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_keys.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_put.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pytables_missing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_read.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_retain_attributes.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_round_trip.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_select.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_store.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_subclass.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_timezones.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_time_series.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ sas
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_sas.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_sas7bdat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_xport.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_sas.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_sas7bdat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_xport.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ xml
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_xml.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_xml.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_xml.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_xml.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ generate_legacy_storage_files.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_clipboard.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_common.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_compression.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_date_converters.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_feather.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_fsspec.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_gcs.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_html.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_orc.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_parquet.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pickle.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_s3.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_spss.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_sql.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_stata.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_user_agent.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ generate_legacy_storage_files.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_clipboard.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_common.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_compression.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_date_converters.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_feather.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_fsspec.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_gcs.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_html.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_orc.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_parquet.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pickle.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_s3.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_spss.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_sql.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_stata.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_user_agent.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ libs
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_hashtable.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_join.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_lib.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_hashtable.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_join.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_lib.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ plotting
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ frame
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_frame.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_frame_color.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_frame_groupby.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_frame_legend.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_frame_subplots.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_hist_box_by.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_frame.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_frame_color.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_frame_groupby.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_frame_legend.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_frame_subplots.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_hist_box_by.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ common.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_backend.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_boxplot_method.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_common.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_converter.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_datetimelike.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_groupby.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_hist_method.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_misc.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_series.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_style.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ common.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_backend.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_boxplot_method.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_common.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_converter.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_datetimelike.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_groupby.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_hist_method.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_misc.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_series.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_style.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ reductions
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reductions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_stat_reductions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reductions.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_stat_reductions.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ resample
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_base.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_datetime_index.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_deprecated.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_period_index.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_resampler_grouper.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_resample_api.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_timedelta.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_time_grouper.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_base.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_datetime_index.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_deprecated.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_period_index.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_resampler_grouper.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_resample_api.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_timedelta.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_time_grouper.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ reshape
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ concat
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_append.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_append_common.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_categorical.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_concat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_dataframe.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_datetimes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_empty.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_index.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_invalid.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_series.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_sort.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_append.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_append_common.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_categorical.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_concat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_dataframe.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_datetimes.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_empty.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_index.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_invalid.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_series.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_sort.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ merge
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_join.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_merge.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_merge_asof.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_merge_cross.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_merge_index_as_string.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_merge_ordered.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_multi.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_join.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_merge.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_merge_asof.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_merge_cross.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_merge_index_as_string.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_merge_ordered.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_multi.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_crosstab.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_cut.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_get_dummies.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_melt.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pivot.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pivot_multilevel.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_qcut.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_union_categoricals.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_util.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_crosstab.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_cut.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_get_dummies.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_melt.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pivot.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pivot_multilevel.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_qcut.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_union_categoricals.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_util.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ scalar
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ interval
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_arithmetic.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_interval.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_ops.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_arithmetic.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_interval.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_ops.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ period
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_asfreq.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_period.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_asfreq.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_period.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ timedelta
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_arithmetic.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_constructors.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_formats.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_timedelta.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_arithmetic.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_constructors.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_formats.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_timedelta.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ timestamp
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_arithmetic.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_comparisons.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_constructors.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_formats.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_rendering.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_timestamp.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_timezones.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_unary_ops.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_arithmetic.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_comparisons.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_constructors.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_formats.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_rendering.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_timestamp.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_timezones.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_unary_ops.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_nat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_na_scalar.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_nat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_na_scalar.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ series
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ accessors
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_cat_accessor.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_dt_accessor.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_sparse_accessor.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_str_accessor.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_cat_accessor.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_dt_accessor.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_sparse_accessor.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_str_accessor.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ indexing
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_datetime.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_delitem.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_get.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_getitem.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_mask.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_setitem.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_set_value.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_take.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_where.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_xs.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_datetime.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_delitem.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_get.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_getitem.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_indexing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_mask.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_setitem.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_set_value.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_take.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_where.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_xs.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ methods
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_align.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_append.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_argsort.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_asof.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_astype.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_autocorr.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_between.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_clip.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_combine.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_combine_first.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_compare.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_convert.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_convert_dtypes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_copy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_count.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_cov_corr.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_describe.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_diff.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_drop.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_dropna.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_drop_duplicates.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_dtypes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_duplicated.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_equals.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_explode.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_fillna.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_get_numeric_data.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_head_tail.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_infer_objects.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_interpolate.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_isin.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_isna.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_is_monotonic.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_is_unique.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_item.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_matmul.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_nlargest.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_nunique.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pct_change.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pop.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_quantile.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_rank.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reindex.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reindex_like.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_rename.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_rename_axis.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_repeat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_replace.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reset_index.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_round.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_searchsorted.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_set_name.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_sort_index.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_sort_values.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_csv.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_dict.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_frame.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_truncate.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_tz_localize.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_unique.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_unstack.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_update.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_values.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_value_counts.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_view.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_align.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_append.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_argsort.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_asof.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_astype.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_autocorr.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_between.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_clip.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_combine.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_combine_first.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_compare.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_convert.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_convert_dtypes.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_copy.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_count.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_cov_corr.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_describe.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_diff.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_drop.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_dropna.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_drop_duplicates.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_dtypes.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_duplicated.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_equals.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_explode.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_fillna.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_get_numeric_data.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_head_tail.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_infer_objects.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_interpolate.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_isin.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_isna.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_is_monotonic.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_is_unique.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_item.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_matmul.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_nlargest.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_nunique.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pct_change.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pop.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_quantile.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_rank.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reindex.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reindex_like.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_rename.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_rename_axis.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_repeat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_replace.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reset_index.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_round.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_searchsorted.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_set_name.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_sort_index.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_sort_values.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_csv.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_dict.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_frame.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_truncate.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_tz_localize.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_unique.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_unstack.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_update.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_values.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_value_counts.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_view.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_api.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_arithmetic.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_constructors.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_cumulative.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_iteration.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_logical_ops.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_missing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_npfuncs.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reductions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_repr.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_subclass.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_ufunc.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_unary.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_validate.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_api.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_arithmetic.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_constructors.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_cumulative.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_iteration.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_logical_ops.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_missing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_npfuncs.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_reductions.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_repr.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_subclass.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_ufunc.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_unary.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_validate.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ strings
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_api.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_case_justify.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_cat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_extract.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_find_replace.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_get_dummies.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_split_partition.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_strings.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_string_array.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_api.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_case_justify.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_cat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_extract.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_find_replace.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_get_dummies.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_split_partition.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_strings.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_string_array.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ tools
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_datetime.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_numeric.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_time.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_timedelta.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_datetime.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_numeric.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_time.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_timedelta.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ tseries
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ frequencies
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_frequencies.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_freq_code.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_inference.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_frequencies.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_freq_code.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_inference.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ holiday
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_calendar.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_federal.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_holiday.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_observance.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_calendar.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_federal.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_holiday.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_observance.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ offsets
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ common.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_business_day.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_business_hour.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_business_month.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_business_quarter.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_business_year.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_custom_business_day.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_custom_business_hour.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_custom_business_month.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_dst.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_easter.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_fiscal.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_index.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_month.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_offsets.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_offsets_properties.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_quarter.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_ticks.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_week.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_year.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ common.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_business_day.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_business_hour.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_business_month.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_business_quarter.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_business_year.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_custom_business_day.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_custom_business_hour.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_custom_business_month.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_dst.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_easter.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_fiscal.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_index.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_month.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_offsets.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_offsets_properties.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_quarter.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_ticks.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_week.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_year.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ tslibs
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_api.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_array_to_datetime.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_ccalendar.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_conversion.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_fields.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_libfrequencies.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_liboffsets.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_parse_iso8601.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_parsing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_period_asfreq.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_timedeltas.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_timezones.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_offset.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_api.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_array_to_datetime.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_ccalendar.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_conversion.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_fields.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_libfrequencies.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_liboffsets.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_parse_iso8601.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_parsing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_period_asfreq.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_timedeltas.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_timezones.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_to_offset.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ util
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_assert_almost_equal.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_assert_attr_equal.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_assert_categorical_equal.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_assert_extension_array_equal.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_assert_frame_equal.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_assert_index_equal.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_assert_interval_array_equal.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_assert_numpy_array_equal.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_assert_produces_warning.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_assert_series_equal.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_deprecate.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_deprecate_kwarg.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_deprecate_nonkeyword_arguments.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_doc.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_hashing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_numba.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_safe_import.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_shares_memory.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_show_versions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_util.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_validate_args.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_validate_args_and_kwargs.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_validate_inclusive.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_validate_kwargs.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_assert_almost_equal.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_assert_attr_equal.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_assert_categorical_equal.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_assert_extension_array_equal.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_assert_frame_equal.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_assert_index_equal.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_assert_interval_array_equal.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_assert_numpy_array_equal.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_assert_produces_warning.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_assert_series_equal.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_deprecate.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_deprecate_kwarg.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_deprecate_nonkeyword_arguments.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_doc.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_hashing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_numba.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_safe_import.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_shares_memory.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_show_versions.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_util.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_validate_args.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_validate_args_and_kwargs.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_validate_inclusive.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_validate_kwargs.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ window
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ moments
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_moments_consistency_ewm.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_moments_consistency_expanding.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_moments_consistency_rolling.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_moments_consistency_ewm.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_moments_consistency_expanding.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_moments_consistency_rolling.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_api.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_apply.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_base_indexer.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_cython_aggregations.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_dtypes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_ewm.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_expanding.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_groupby.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_numba.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_online.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pairwise.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_rolling.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_rolling_functions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_rolling_quantile.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_rolling_skew_kurt.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_timeseries_window.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_win_type.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_api.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_apply.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_base_indexer.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_cython_aggregations.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_dtypes.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_ewm.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_expanding.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_groupby.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_numba.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_online.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pairwise.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_rolling.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_rolling_functions.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_rolling_quantile.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_rolling_skew_kurt.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_timeseries_window.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_win_type.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_aggregation.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_algos.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_common.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_downstream.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_errors.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_expressions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_flags.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_multilevel.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_nanops.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_optional_dependency.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_register_accessor.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_sorting.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_take.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ test_aggregation.py
 ┃ ┃ ┃ ┃ ┃ ┣ test_algos.py
 ┃ ┃ ┃ ┃ ┃ ┣ test_common.py
 ┃ ┃ ┃ ┃ ┃ ┣ test_downstream.py
 ┃ ┃ ┃ ┃ ┃ ┣ test_errors.py
 ┃ ┃ ┃ ┃ ┃ ┣ test_expressions.py
 ┃ ┃ ┃ ┃ ┃ ┣ test_flags.py
 ┃ ┃ ┃ ┃ ┃ ┣ test_multilevel.py
 ┃ ┃ ┃ ┃ ┃ ┣ test_nanops.py
 ┃ ┃ ┃ ┃ ┃ ┣ test_optional_dependency.py
 ┃ ┃ ┃ ┃ ┃ ┣ test_register_accessor.py
 ┃ ┃ ┃ ┃ ┃ ┣ test_sorting.py
 ┃ ┃ ┃ ┃ ┃ ┣ test_take.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ tseries
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ api.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ frequencies.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ holiday.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ offsets.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ api.py
 ┃ ┃ ┃ ┃ ┃ ┣ frequencies.py
 ┃ ┃ ┃ ┃ ┃ ┣ holiday.py
 ┃ ┃ ┃ ┃ ┃ ┣ offsets.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ util
 ┃ ┃ ┃ ┃ ┃ ┣ version
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ testing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _decorators.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _doctools.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _exceptions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _print_versions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _tester.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _test_decorators.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _validators.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ testing.py
 ┃ ┃ ┃ ┃ ┃ ┣ _decorators.py
 ┃ ┃ ┃ ┃ ┃ ┣ _doctools.py
 ┃ ┃ ┃ ┃ ┃ ┣ _exceptions.py
 ┃ ┃ ┃ ┃ ┃ ┣ _print_versions.py
 ┃ ┃ ┃ ┃ ┃ ┣ _tester.py
 ┃ ┃ ┃ ┃ ┃ ┣ _test_decorators.py
 ┃ ┃ ┃ ┃ ┃ ┣ _validators.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ _config
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ config.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ dates.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ display.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ localization.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ config.py
 ┃ ┃ ┃ ┃ ┃ ┣ dates.py
 ┃ ┃ ┃ ┃ ┃ ┣ display.py
 ┃ ┃ ┃ ┃ ┃ ┣ localization.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ _libs
 ┃ ┃ ┃ ┃ ┃ ┣ src
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ headers
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ cmath
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ms_inttypes.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ms_stdint.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ portable.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ stdint.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ klib
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ khash.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ khash_python.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ parser
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ io.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ io.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ tokenizer.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ tokenizer.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ ujson
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ lib
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ultrajson.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ultrajsondec.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ ultrajsonenc.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ python
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ date_conversions.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ date_conversions.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ JSONtoObj.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ objToJSON.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ujson.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ version.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ inline_helper.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ parse_helper.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ skiplist.h
 ┃ ┃ ┃ ┃ ┃ ┣ tslibs
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ src
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ datetime
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ np_datetime.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ np_datetime.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ np_datetime_strings.c
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ np_datetime_strings.h
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ base.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ base.pxd
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ base.pyx
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ ccalendar.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ ccalendar.pxd
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ ccalendar.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ ccalendar.pyx
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ conversion.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ conversion.pxd
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ conversion.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ conversion.pyx
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ dtypes.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ dtypes.pxd
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ dtypes.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ dtypes.pyx
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fields.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fields.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fields.pyx
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ nattype.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ nattype.pxd
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ nattype.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ nattype.pyx
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ np_datetime.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ np_datetime.pxd
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ np_datetime.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ np_datetime.pyx
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ offsets.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ offsets.pxd
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ offsets.pyx
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ parsing.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ parsing.pxd
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ parsing.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ parsing.pyx
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ period.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ period.pxd
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ period.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ period.pyx
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ strptime.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ strptime.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ strptime.pyx
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ timedeltas.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ timedeltas.pxd
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ timedeltas.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ timedeltas.pyx
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ timestamps.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ timestamps.pxd
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ timestamps.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ timestamps.pyx
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ timezones.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ timezones.pxd
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ timezones.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ timezones.pyx
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ tzconversion.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ tzconversion.pxd
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ tzconversion.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ tzconversion.pyx
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ util.pxd
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ vectorized.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ vectorized.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ vectorized.pyx
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ window
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ aggregations.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ aggregations.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ aggregations.pyx
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ concrt140.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ indexers.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ indexers.pyi
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ indexers.pyx
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ msvcp140.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ vcruntime140_1.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ algos.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ algos.pxd
 ┃ ┃ ┃ ┃ ┃ ┣ algos.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ algos.pyx
 ┃ ┃ ┃ ┃ ┃ ┣ algos_common_helper.pxi.in
 ┃ ┃ ┃ ┃ ┃ ┣ algos_take_helper.pxi.in
 ┃ ┃ ┃ ┃ ┃ ┣ arrays.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ arrays.pxd
 ┃ ┃ ┃ ┃ ┃ ┣ arrays.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ arrays.pyx
 ┃ ┃ ┃ ┃ ┃ ┣ dtypes.pxd
 ┃ ┃ ┃ ┃ ┃ ┣ groupby.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ groupby.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ groupby.pyx
 ┃ ┃ ┃ ┃ ┃ ┣ hashing.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ hashing.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ hashing.pyx
 ┃ ┃ ┃ ┃ ┃ ┣ hashtable.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ hashtable.pxd
 ┃ ┃ ┃ ┃ ┃ ┣ hashtable.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ hashtable.pyx
 ┃ ┃ ┃ ┃ ┃ ┣ hashtable_class_helper.pxi.in
 ┃ ┃ ┃ ┃ ┃ ┣ hashtable_func_helper.pxi.in
 ┃ ┃ ┃ ┃ ┃ ┣ index.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ index.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ index.pyx
 ┃ ┃ ┃ ┃ ┃ ┣ indexing.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ indexing.pyx
 ┃ ┃ ┃ ┃ ┃ ┣ index_class_helper.pxi.in
 ┃ ┃ ┃ ┃ ┃ ┣ internals.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ internals.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ internals.pyx
 ┃ ┃ ┃ ┃ ┃ ┣ interval.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ interval.pyx
 ┃ ┃ ┃ ┃ ┃ ┣ intervaltree.pxi.in
 ┃ ┃ ┃ ┃ ┃ ┣ join.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ join.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ join.pyx
 ┃ ┃ ┃ ┃ ┃ ┣ json.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ khash.pxd
 ┃ ┃ ┃ ┃ ┃ ┣ khash_for_primitive_helper.pxi.in
 ┃ ┃ ┃ ┃ ┃ ┣ lib.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ lib.pxd
 ┃ ┃ ┃ ┃ ┃ ┣ lib.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ lib.pyx
 ┃ ┃ ┃ ┃ ┃ ┣ missing.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ missing.pxd
 ┃ ┃ ┃ ┃ ┃ ┣ missing.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ missing.pyx
 ┃ ┃ ┃ ┃ ┃ ┣ ops.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ ops.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ ops.pyx
 ┃ ┃ ┃ ┃ ┃ ┣ ops_dispatch.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ ops_dispatch.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ ops_dispatch.pyx
 ┃ ┃ ┃ ┃ ┃ ┣ parsers.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ parsers.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ parsers.pyx
 ┃ ┃ ┃ ┃ ┃ ┣ properties.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ properties.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ properties.pyx
 ┃ ┃ ┃ ┃ ┃ ┣ reduction.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ reduction.pyx
 ┃ ┃ ┃ ┃ ┃ ┣ reshape.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ reshape.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ reshape.pyx
 ┃ ┃ ┃ ┃ ┃ ┣ sparse.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ sparse.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ sparse.pyx
 ┃ ┃ ┃ ┃ ┃ ┣ sparse_op_helper.pxi.in
 ┃ ┃ ┃ ┃ ┃ ┣ testing.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ testing.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ testing.pyx
 ┃ ┃ ┃ ┃ ┃ ┣ tslib.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ tslib.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ tslib.pyx
 ┃ ┃ ┃ ┃ ┃ ┣ util.pxd
 ┃ ┃ ┃ ┃ ┃ ┣ writers.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┣ writers.pyi
 ┃ ┃ ┃ ┃ ┃ ┣ writers.pyx
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ _testing
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ asserters.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ compat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ contexts.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _hypothesis.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _io.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _random.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _warnings.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ asserters.py
 ┃ ┃ ┃ ┃ ┃ ┣ compat.py
 ┃ ┃ ┃ ┃ ┃ ┣ contexts.py
 ┃ ┃ ┃ ┃ ┃ ┣ _hypothesis.py
 ┃ ┃ ┃ ┃ ┃ ┣ _io.py
 ┃ ┃ ┃ ┃ ┃ ┣ _random.py
 ┃ ┃ ┃ ┃ ┃ ┣ _warnings.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┣ conftest.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ testing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _typing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _version.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┣ conftest.py
 ┃ ┃ ┃ ┃ ┣ testing.py
 ┃ ┃ ┃ ┃ ┣ _typing.py
 ┃ ┃ ┃ ┃ ┣ _version.py
 ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┣ pandas-1.4.1.dist-info
 ┃ ┃ ┃ ┃ ┣ entry_points.txt
 ┃ ┃ ┃ ┃ ┣ INSTALLER
 ┃ ┃ ┃ ┃ ┣ LICENSE
 ┃ ┃ ┃ ┃ ┣ METADATA
 ┃ ┃ ┃ ┃ ┣ RECORD
 ┃ ┃ ┃ ┃ ┣ REQUESTED
 ┃ ┃ ┃ ┃ ┣ top_level.txt
 ┃ ┃ ┃ ┃ ┗ WHEEL
 ┃ ┃ ┃ ┣ past
 ┃ ┃ ┃ ┃ ┣ builtins
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ misc.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ noniterators.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ misc.py
 ┃ ┃ ┃ ┃ ┃ ┣ noniterators.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ translation
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ types
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ basestring.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ olddict.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ oldstr.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ basestring.py
 ┃ ┃ ┃ ┃ ┃ ┣ olddict.py
 ┃ ┃ ┃ ┃ ┃ ┣ oldstr.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ utils
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┣ pefile-2021.9.3.dist-info
 ┃ ┃ ┃ ┃ ┣ INSTALLER
 ┃ ┃ ┃ ┃ ┣ LICENSE
 ┃ ┃ ┃ ┃ ┣ METADATA
 ┃ ┃ ┃ ┃ ┣ RECORD
 ┃ ┃ ┃ ┃ ┣ top_level.txt
 ┃ ┃ ┃ ┃ ┗ WHEEL
 ┃ ┃ ┃ ┣ pip
 ┃ ┃ ┃ ┃ ┣ _internal
 ┃ ┃ ┃ ┃ ┃ ┣ cli
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ autocompletion.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ base_command.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ cmdoptions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ command_context.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ main.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ main_parser.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ parser.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ progress_bars.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ req_command.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ spinners.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ status_codes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ autocompletion.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ base_command.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cmdoptions.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ command_context.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ main.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ main_parser.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ parser.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ progress_bars.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ req_command.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ spinners.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ status_codes.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ commands
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ freeze.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ install.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cache.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ check.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ completion.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ configuration.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ debug.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ download.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ freeze.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hash.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ help.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ install.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ list.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ search.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ show.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ uninstall.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ wheel.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ distributions
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ base.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ installed.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ sdist.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ wheel.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ base.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ installed.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ sdist.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ wheel.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ index
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ collector.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ package_finder.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ sources.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ collector.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ package_finder.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ sources.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ locations
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ base.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _distutils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _sysconfig.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ base.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _distutils.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _sysconfig.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ metadata
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ base.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pkg_resources.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ base.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pkg_resources.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ models
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ candidate.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ direct_url.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ format_control.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ index.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ link.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ scheme.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ search_scope.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ selection_prefs.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ target_python.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ wheel.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ candidate.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ direct_url.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ format_control.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ index.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ link.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ scheme.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ search_scope.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ selection_prefs.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ target_python.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ wheel.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ network
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ auth.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ cache.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ download.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ lazy_wheel.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ session.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ utils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ auth.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cache.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ download.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ lazy_wheel.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ session.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ utils.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ xmlrpc.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ operations
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ build
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ metadata.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ metadata_legacy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ wheel.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ wheel_legacy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ metadata.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ metadata_legacy.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ wheel.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ wheel_legacy.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ install
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ editable_legacy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ legacy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ wheel.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ editable_legacy.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ legacy.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ wheel.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ check.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ freeze.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ prepare.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ check.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ freeze.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ prepare.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ req
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ constructors.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ req_file.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ req_install.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ req_set.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ req_tracker.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ req_uninstall.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ constructors.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ req_file.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ req_install.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ req_set.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ req_tracker.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ req_uninstall.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ resolution
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ legacy
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ resolver.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ resolvelib
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ base.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ candidates.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ factory.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ found_candidates.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ provider.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ reporter.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ requirements.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ resolver.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ base.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ candidates.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ factory.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ found_candidates.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ provider.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ reporter.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ requirements.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ resolver.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ base.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ base.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ utils
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ appdirs.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ compat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ compatibility_tags.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ deprecation.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ direct_url_helpers.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ distutils_args.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ encoding.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ filesystem.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ filetypes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ glibc.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hashes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ inject_securetransport.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ logging.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ misc.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ models.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ packaging.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pkg_resources.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ setuptools_build.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ subprocess.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ temp_dir.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ unpacking.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ urls.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ virtualenv.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ wheel.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ appdirs.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ compat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ compatibility_tags.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ datetime.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ deprecation.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ direct_url_helpers.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ distutils_args.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ encoding.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ entrypoints.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ filesystem.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ filetypes.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ glibc.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hashes.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ inject_securetransport.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ logging.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ misc.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ models.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ packaging.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ parallel.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pkg_resources.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ setuptools_build.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ subprocess.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ temp_dir.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ unpacking.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ urls.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ virtualenv.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ wheel.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ vcs
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ bazaar.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ git.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ mercurial.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ subversion.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ versioncontrol.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ bazaar.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ git.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ mercurial.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ subversion.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ versioncontrol.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ build_env.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cache.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ configuration.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ exceptions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyproject.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ self_outdated_check.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ wheel_builder.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ build_env.py
 ┃ ┃ ┃ ┃ ┃ ┣ cache.py
 ┃ ┃ ┃ ┃ ┃ ┣ configuration.py
 ┃ ┃ ┃ ┃ ┃ ┣ exceptions.py
 ┃ ┃ ┃ ┃ ┃ ┣ main.py
 ┃ ┃ ┃ ┃ ┃ ┣ pyproject.py
 ┃ ┃ ┃ ┃ ┃ ┣ self_outdated_check.py
 ┃ ┃ ┃ ┃ ┃ ┣ wheel_builder.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ _vendor
 ┃ ┃ ┃ ┃ ┃ ┣ cachecontrol
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ caches
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ file_cache.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ redis_cache.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ file_cache.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ redis_cache.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ adapter.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ cache.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ compat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ controller.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ filewrapper.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ serialize.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ wrapper.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ adapter.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cache.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ compat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ controller.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ filewrapper.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ heuristics.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ serialize.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ wrapper.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _cmd.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ certifi
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ core.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cacert.pem
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ core.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __main__.py
 ┃ ┃ ┃ ┃ ┃ ┣ chardet
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cli
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ chardetect.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ metadata
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ languages.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ big5freq.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ big5prober.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ chardistribution.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ charsetgroupprober.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ charsetprober.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ codingstatemachine.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ cp949prober.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ enums.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ escprober.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ escsm.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ eucjpprober.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ euckrfreq.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ euckrprober.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ euctwfreq.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ euctwprober.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ gb2312freq.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ gb2312prober.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hebrewprober.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ jisfreq.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ jpcntx.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ langbulgarianmodel.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ langgreekmodel.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ langhebrewmodel.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ langrussianmodel.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ langthaimodel.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ langturkishmodel.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ latin1prober.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ mbcharsetprober.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ mbcsgroupprober.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ mbcssm.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ sbcharsetprober.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ sbcsgroupprober.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ sjisprober.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ universaldetector.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ utf8prober.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ version.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ big5freq.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ big5prober.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ chardistribution.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ charsetgroupprober.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ charsetprober.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ codingstatemachine.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ compat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cp949prober.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ enums.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ escprober.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ escsm.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ eucjpprober.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ euckrfreq.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ euckrprober.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ euctwfreq.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ euctwprober.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ gb2312freq.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ gb2312prober.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hebrewprober.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ jisfreq.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ jpcntx.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ langbulgarianmodel.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ langgreekmodel.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ langhebrewmodel.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ langhungarianmodel.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ langrussianmodel.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ langthaimodel.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ langturkishmodel.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ latin1prober.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ mbcharsetprober.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ mbcsgroupprober.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ mbcssm.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ sbcharsetprober.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ sbcsgroupprober.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ sjisprober.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ universaldetector.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ utf8prober.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ version.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ colorama
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ansi.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ansitowin32.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ initialise.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ win32.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ winterm.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ ansi.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ ansitowin32.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ initialise.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ win32.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ winterm.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ distlib
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _backport
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ misc.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ shutil.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ sysconfig.cfg
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ sysconfig.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ tarfile.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ compat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ resources.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ scripts.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ util.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ compat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ database.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ index.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ locators.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ manifest.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ markers.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ metadata.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ resources.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ scripts.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ t32.exe
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ t64.exe
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ util.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ version.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ w32.exe
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ w64.exe
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ wheel.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ html5lib
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ filters
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ alphabeticalattributes.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ base.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ inject_meta_charset.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ lint.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ optionaltags.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ sanitizer.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ whitespace.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ treeadapters
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ genshi.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ sax.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ treebuilders
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ base.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ etree.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ base.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ dom.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ etree.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ etree_lxml.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ treewalkers
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ base.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ dom.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ etree.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ etree_lxml.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ genshi.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _trie
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ py.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _base.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ py.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _base.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ constants.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ html5parser.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ serializer.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _ihatexml.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _inputstream.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _tokenizer.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _utils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ constants.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ html5parser.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ serializer.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _ihatexml.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _inputstream.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _tokenizer.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _utils.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ idna
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ core.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ idnadata.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ intranges.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ package_data.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ codec.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ compat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ core.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ idnadata.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ intranges.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ package_data.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ uts46data.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ msgpack
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ exceptions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ext.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ fallback.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _version.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ exceptions.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ ext.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fallback.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _version.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ packaging
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ markers.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ requirements.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ specifiers.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ tags.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ utils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ version.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _compat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _structures.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _typing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __about__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ markers.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ requirements.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ specifiers.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ tags.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ utils.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ version.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _compat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _structures.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _typing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __about__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ pep517
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ in_process
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _in_process.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ compat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ wrappers.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ build.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ check.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ colorlog.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ compat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ dirtools.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ envbuild.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ meta.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ wrappers.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ pkg_resources
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ py31compat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ py31compat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ progress
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ bar.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ spinner.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ bar.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ counter.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ spinner.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ requests
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ adapters.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ api.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ auth.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ certs.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ compat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ cookies.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ exceptions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hooks.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ models.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ packages.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ sessions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ status_codes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ structures.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ utils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _internal_utils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __version__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ adapters.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ api.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ auth.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ certs.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ compat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cookies.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ exceptions.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ help.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hooks.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ models.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ packages.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ sessions.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ status_codes.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ structures.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ utils.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _internal_utils.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __version__.py
 ┃ ┃ ┃ ┃ ┃ ┣ resolvelib
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ compat
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ collections_abc.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ collections_abc.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ providers.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ reporters.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ resolvers.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ structs.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ providers.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ reporters.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ resolvers.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ structs.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ tenacity
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ after.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ before.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ before_sleep.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ compat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ nap.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ retry.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ stop.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ wait.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _asyncio.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _utils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ after.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ before.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ before_sleep.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ compat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ nap.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ retry.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ stop.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ tornadoweb.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ wait.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _asyncio.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _utils.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ toml
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ decoder.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ encoder.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ tz.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ decoder.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ encoder.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ ordered.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ tz.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ urllib3
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ contrib
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _securetransport
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ bindings.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ low_level.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ socks.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _appengine_environ.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ appengine.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ntlmpool.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyopenssl.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ securetransport.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ socks.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _appengine_environ.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ packages
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ backports
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ makefile.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ssl_match_hostname
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _implementation.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ six.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ six.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ util
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ connection.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ proxy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ queue.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ request.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ response.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ retry.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ssltransport.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ssl_.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ timeout.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ url.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ wait.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ connection.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ proxy.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ queue.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ request.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ response.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ retry.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ssltransport.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ssl_.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ timeout.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ url.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ wait.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ connection.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ connectionpool.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ exceptions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ fields.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ filepost.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ poolmanager.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ request.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ response.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _collections.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _version.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ connection.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ connectionpool.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ exceptions.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ fields.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ filepost.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ poolmanager.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ request.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ response.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _collections.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _version.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ webencodings
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ labels.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ labels.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ mklabels.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ tests.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ x_user_defined.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ appdirs.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyparsing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ six.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ appdirs.py
 ┃ ┃ ┃ ┃ ┃ ┣ distro.py
 ┃ ┃ ┃ ┃ ┃ ┣ pyparsing.py
 ┃ ┃ ┃ ┃ ┃ ┣ six.py
 ┃ ┃ ┃ ┃ ┃ ┣ vendor.txt
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┣ py.typed
 ┃ ┃ ┃ ┃ ┣ __init__.py
 ┃ ┃ ┃ ┃ ┗ __main__.py
 ┃ ┃ ┃ ┣ pip-21.1.2.dist-info
 ┃ ┃ ┃ ┃ ┣ entry_points.txt
 ┃ ┃ ┃ ┃ ┣ INSTALLER
 ┃ ┃ ┃ ┃ ┣ LICENSE.txt
 ┃ ┃ ┃ ┃ ┣ METADATA
 ┃ ┃ ┃ ┃ ┣ RECORD
 ┃ ┃ ┃ ┃ ┣ top_level.txt
 ┃ ┃ ┃ ┃ ┗ WHEEL
 ┃ ┃ ┃ ┣ pkg_resources
 ┃ ┃ ┃ ┃ ┣ extern
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ tests
 ┃ ┃ ┃ ┃ ┃ ┗ data
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ my-test-package-source
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ setup.py
 ┃ ┃ ┃ ┃ ┣ _vendor
 ┃ ┃ ┃ ┃ ┃ ┣ packaging
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ markers.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ requirements.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ specifiers.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ utils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ version.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _compat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _structures.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _typing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __about__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ markers.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ requirements.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ specifiers.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ tags.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ utils.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ version.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _compat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _structures.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _typing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __about__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ appdirs.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyparsing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ appdirs.py
 ┃ ┃ ┃ ┃ ┃ ┣ pyparsing.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┣ pycparser
 ┃ ┃ ┃ ┃ ┣ ply
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ cpp.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ ctokens.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ lex.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ yacc.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ ygen.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ cpp.py
 ┃ ┃ ┃ ┃ ┃ ┣ ctokens.py
 ┃ ┃ ┃ ┃ ┃ ┣ lex.py
 ┃ ┃ ┃ ┃ ┃ ┣ yacc.py
 ┃ ┃ ┃ ┃ ┃ ┣ ygen.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┣ ast_transforms.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ c_ast.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ c_generator.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ c_lexer.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ c_parser.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ lextab.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ plyparser.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ yacctab.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _ast_gen.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _build_tables.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┣ ast_transforms.py
 ┃ ┃ ┃ ┃ ┣ c_ast.py
 ┃ ┃ ┃ ┃ ┣ c_generator.py
 ┃ ┃ ┃ ┃ ┣ c_lexer.py
 ┃ ┃ ┃ ┃ ┣ c_parser.py
 ┃ ┃ ┃ ┃ ┣ lextab.py
 ┃ ┃ ┃ ┃ ┣ plyparser.py
 ┃ ┃ ┃ ┃ ┣ yacctab.py
 ┃ ┃ ┃ ┃ ┣ _ast_gen.py
 ┃ ┃ ┃ ┃ ┣ _build_tables.py
 ┃ ┃ ┃ ┃ ┣ _c_ast.cfg
 ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┣ pycparser-2.21.dist-info
 ┃ ┃ ┃ ┃ ┣ INSTALLER
 ┃ ┃ ┃ ┃ ┣ LICENSE
 ┃ ┃ ┃ ┃ ┣ METADATA
 ┃ ┃ ┃ ┃ ┣ RECORD
 ┃ ┃ ┃ ┃ ┣ top_level.txt
 ┃ ┃ ┃ ┃ ┗ WHEEL
 ┃ ┃ ┃ ┣ PyInstaller
 ┃ ┃ ┃ ┃ ┣ archive
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyz_crypto.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ readers.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ writers.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ pyz_crypto.py
 ┃ ┃ ┃ ┃ ┃ ┣ readers.py
 ┃ ┃ ┃ ┃ ┃ ┣ writers.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ bootloader
 ┃ ┃ ┃ ┃ ┃ ┣ images
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ github_logo.png
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ icon-console.icns
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ icon-console.ico
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ icon-console.svg
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ icon-windowed.icns
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ icon-windowed.ico
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ icon-windowed.svg
 ┃ ┃ ┃ ┃ ┃ ┗ Windows-64bit
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ run.exe
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ runw.exe
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ runw_d.exe
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ run_d.exe
 ┃ ┃ ┃ ┃ ┣ building
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ api.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ build_main.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ datastruct.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ makespec.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ osx.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ splash.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ splash_templates.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ templates.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ toc_conversion.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ utils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ api.py
 ┃ ┃ ┃ ┃ ┃ ┣ build_main.py
 ┃ ┃ ┃ ┃ ┃ ┣ datastruct.py
 ┃ ┃ ┃ ┃ ┃ ┣ makespec.py
 ┃ ┃ ┃ ┃ ┃ ┣ osx.py
 ┃ ┃ ┃ ┃ ┃ ┣ splash.py
 ┃ ┃ ┃ ┃ ┃ ┣ splash_templates.py
 ┃ ┃ ┃ ┃ ┃ ┣ templates.py
 ┃ ┃ ┃ ┃ ┃ ┣ toc_conversion.py
 ┃ ┃ ┃ ┃ ┃ ┣ utils.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ depend
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ analysis.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ bindepend.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ bytecode.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ dylib.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ imphook.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ imphookapi.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ utils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ analysis.py
 ┃ ┃ ┃ ┃ ┃ ┣ bindepend.py
 ┃ ┃ ┃ ┃ ┃ ┣ bytecode.py
 ┃ ┃ ┃ ┃ ┃ ┣ dylib.py
 ┃ ┃ ┃ ┃ ┃ ┣ imphook.py
 ┃ ┃ ┃ ┃ ┃ ┣ imphookapi.py
 ┃ ┃ ┃ ┃ ┃ ┣ utils.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ fake-modules
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_splash.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ site.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ pyi_splash.py
 ┃ ┃ ┃ ┃ ┃ ┗ site.py
 ┃ ┃ ┃ ┃ ┣ hooks
 ┃ ┃ ┃ ┃ ┃ ┣ pre_find_module_path
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-distutils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyi_splash.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.uic.port_v2.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-site.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-distutils.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyi_splash.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.uic.port_v2.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-site.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ pre_safe_import_module
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.Atk.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.cairo.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.Champlain.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.Clutter.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.Gdk.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GdkPixbuf.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.Gio.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GIRepository.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GLib.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GModule.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GObject.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.Gst.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GstAudio.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GstBase.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GstPbutils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GstTag.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GstVideo.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.Gtk.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GtkChamplain.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GtkClutter.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GtkosxApplication.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GtkSource.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.HarfBuzz.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.Pango.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.PangoCairo.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.xlib.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-setuptools.extern.six.moves.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-six.moves.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-urllib3.packages.six.moves.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.Atk.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.cairo.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.Champlain.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.Clutter.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.Gdk.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GdkPixbuf.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.Gio.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GIRepository.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GLib.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GModule.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GObject.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.Gst.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GstAudio.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GstBase.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GstPbutils.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GstTag.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GstVideo.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.Gtk.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GtkChamplain.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GtkClutter.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GtkosxApplication.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GtkSource.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.HarfBuzz.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.Pango.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.PangoCairo.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.xlib.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-setuptools.extern.six.moves.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-six.moves.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-urllib3.packages.six.moves.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ rthooks
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_django.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_gdkpixbuf.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_gi.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_gio.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_glib.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_gstreamer.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_gtk.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_inspect.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_kivy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_mplconfig.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_multiprocessing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_pkgres.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_pkgutil.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_pyqt5.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_pyqt5webengine.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_pyqt6.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_pyqt6webengine.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_pyside2.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_pyside2webengine.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_pyside6.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_pyside6webengine.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_subprocess.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_win32api.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_win32comgenpy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth__tkinter.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_django.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_gdkpixbuf.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_gi.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_gio.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_glib.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_gstreamer.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_gtk.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_inspect.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_kivy.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_mplconfig.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_multiprocessing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_pkgres.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_pkgutil.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_pyqt5.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_pyqt5webengine.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_pyqt6.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_pyqt6webengine.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_pyside2.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_pyside2webengine.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_pyside6.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_pyside6webengine.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_subprocess.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_win32api.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_win32comgenpy.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth__tkinter.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-babel.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-difflib.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-distutils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-distutils.util.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-django.contrib.sessions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-django.core.cache.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-django.core.mail.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-django.core.management.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-django.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-django.db.backends.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-django.db.backends.mysql.base.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-django.db.backends.oracle.base.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-django.template.loaders.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-encodings.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gevent.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.Atk.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.cairo.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.Champlain.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.Clutter.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.Gdk.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GdkPixbuf.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.Gio.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GIRepository.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GLib.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GModule.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GObject.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.Gst.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GstAudio.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GstBase.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GstPbutils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GstTag.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GstVideo.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.Gtk.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GtkChamplain.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GtkClutter.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GtkosxApplication.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GtkSource.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.HarfBuzz.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.Pango.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.PangoCairo.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.xlib.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-heapq.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-idlelib.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-importlib_metadata.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-importlib_resources.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-keyring.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-kivy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-lib2to3.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-matplotlib.backends.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-matplotlib.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-matplotlib.numerix.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-multiprocessing.util.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-numpy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-numpy._pytesttester.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-packaging.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pandas.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pandas.io.formats.style.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pandas.plotting.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pickle.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PIL.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PIL.Image.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PIL.ImageFilter.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PIL.SpiderImagePlugin.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pkg_resources.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pygments.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.Qt.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtCore.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtGui.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtHelp.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtLocation.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtMultimedia.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtMultimediaWidgets.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtNetwork.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtOpenGL.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtPositioning.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtPrintSupport.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtQml.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtQuick.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtQuickWidgets.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtScript.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtSensors.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtSerialPort.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtSql.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtSvg.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtTest.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtWebEngineWidgets.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtWebKit.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtWebKitWidgets.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtWidgets.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtXml.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.uic.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.QtCore.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.QtGui.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.QtHelp.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.QtMultimedia.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.QtMultimediaWidgets.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.QtNetwork.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.QtOpenGL.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.QtOpenGLWidgets.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.QtPrintSupport.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.QtQml.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.QtQuick.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.QtQuickWidgets.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.QtSql.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.QtSvg.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.QtTest.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.QtWebEngineWidgets.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.QtWidgets.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.QtXml.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.uic.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtCore.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtGui.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtHelp.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtLocation.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtMultimedia.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtMultimediaWidgets.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtNetwork.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtOpenGL.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtPositioning.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtPrintSupport.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtQml.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtQuick.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtQuickWidgets.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtScript.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtSensors.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtSerialPort.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtSql.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtSvg.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtTest.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtUiTools.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtWebEngineWidgets.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtWebKit.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtWebKitWidgets.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtWidgets.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtXml.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.Qwt5.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtCore.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtGui.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtHelp.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtMultimedia.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtMultimediaWidgets.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtNetwork.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtOpenGL.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtOpenGLWidgets.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtPrintSupport.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtQml.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtQuick.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtQuickWidgets.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtSql.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtSvg.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtTest.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtUiTools.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtWebEngineWidgets.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtWidgets.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtXml.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pytz.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pytzdata.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-qtawesome.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-scapy.layers.all.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-scipy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-scipy.io.matlab.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-scipy.linalg.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-scipy.sparse.csgraph.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-scipy.spatial.transform.rotation.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-scipy.special._ellip_harm_2.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-scipy.special._ufuncs.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-scipy.stats._stats.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-scrapy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-setuptools.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-setuptools.msvc.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-shelve.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-sphinx.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-sqlalchemy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-sqlite3.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-sysconfig.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-wcwidth.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-win32ctypes.core.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-xml.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-xml.dom.domreg.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-xml.etree.cElementTree.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-zope.interface.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-_tkinter.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ hook-babel.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-difflib.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-distutils.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-distutils.util.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-django.contrib.sessions.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-django.core.cache.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-django.core.mail.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-django.core.management.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-django.db.backends.mysql.base.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-django.db.backends.oracle.base.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-django.db.backends.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-django.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-django.template.loaders.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-encodings.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-gevent.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.Atk.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.cairo.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.Champlain.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.Clutter.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.Gdk.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GdkPixbuf.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.Gio.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GIRepository.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GLib.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GModule.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GObject.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.Gst.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GstAudio.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GstBase.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GstPbutils.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GstTag.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GstVideo.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.Gtk.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GtkChamplain.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GtkClutter.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GtkosxApplication.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.GtkSource.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.HarfBuzz.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.Pango.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.PangoCairo.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-gi.repository.xlib.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-heapq.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-idlelib.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-importlib_metadata.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-importlib_resources.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-keyring.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-kivy.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-lib2to3.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-matplotlib.backends.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-matplotlib.numerix.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-matplotlib.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-multiprocessing.util.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-numpy.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-numpy._pytesttester.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-packaging.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-pandas.io.formats.style.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-pandas.plotting.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-pandas.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-pickle.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PIL.Image.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PIL.ImageFilter.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PIL.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PIL.SpiderImagePlugin.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-pkg_resources.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-pygments.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.Qt.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtCore.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtGui.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtHelp.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtLocation.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtMultimedia.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtMultimediaWidgets.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtNetwork.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtOpenGL.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtPositioning.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtPrintSupport.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtQml.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtQuick.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtQuickWidgets.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtScript.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtSensors.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtSerialPort.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtSql.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtSvg.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtTest.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtWebEngineWidgets.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtWebKit.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtWebKitWidgets.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtWidgets.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.QtXml.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt5.uic.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.QtCore.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.QtGui.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.QtHelp.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.QtMultimedia.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.QtMultimediaWidgets.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.QtNetwork.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.QtOpenGL.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.QtOpenGLWidgets.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.QtPrintSupport.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.QtQml.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.QtQuick.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.QtQuickWidgets.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.QtSql.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.QtSvg.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.QtTest.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.QtWebEngineWidgets.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.QtWidgets.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.QtXml.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PyQt6.uic.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtCore.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtGui.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtHelp.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtLocation.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtMultimedia.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtMultimediaWidgets.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtNetwork.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtOpenGL.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtPositioning.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtPrintSupport.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtQml.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtQuick.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtQuickWidgets.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtScript.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtSensors.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtSerialPort.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtSql.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtSvg.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtTest.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtUiTools.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtWebEngineWidgets.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtWebKit.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtWebKitWidgets.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtWidgets.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.QtXml.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide2.Qwt5.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtCore.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtGui.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtHelp.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtMultimedia.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtMultimediaWidgets.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtNetwork.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtOpenGL.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtOpenGLWidgets.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtPrintSupport.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtQml.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtQuick.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtQuickWidgets.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtSql.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtSvg.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtTest.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtUiTools.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtWebEngineWidgets.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtWidgets.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-PySide6.QtXml.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-pytz.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-pytzdata.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-qtawesome.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-scapy.layers.all.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-scipy.io.matlab.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-scipy.linalg.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-scipy.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-scipy.sparse.csgraph.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-scipy.spatial.transform.rotation.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-scipy.special._ellip_harm_2.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-scipy.special._ufuncs.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-scipy.stats._stats.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-scrapy.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-setuptools.msvc.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-setuptools.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-shelve.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-sphinx.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-sqlalchemy.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-sqlite3.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-sysconfig.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-wcwidth.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-win32ctypes.core.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-xml.dom.domreg.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-xml.etree.cElementTree.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-xml.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-zope.interface.py
 ┃ ┃ ┃ ┃ ┃ ┣ hook-_tkinter.py
 ┃ ┃ ┃ ┃ ┃ ┣ rthooks.dat
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ lib
 ┃ ┃ ┃ ┃ ┃ ┣ modulegraph
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ find_modules.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ modulegraph.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ util.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ zipio.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _compat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __main__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ find_modules.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ modulegraph.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ util.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ zipio.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _compat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __main__.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ README.rst
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ loader
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyiboot01_bootstrap.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyimod01_os_path.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyimod02_archive.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyimod03_importers.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyimod04_ctypes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ pyiboot01_bootstrap.py
 ┃ ┃ ┃ ┃ ┃ ┣ pyimod01_os_path.py
 ┃ ┃ ┃ ┃ ┃ ┣ pyimod01_os_path.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ pyimod02_archive.py
 ┃ ┃ ┃ ┃ ┃ ┣ pyimod02_archive.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ pyimod03_importers.py
 ┃ ┃ ┃ ┃ ┃ ┣ pyimod03_importers.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ pyimod04_ctypes.py
 ┃ ┃ ┃ ┃ ┃ ┣ pyimod04_ctypes.pyc
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ utils
 ┃ ┃ ┃ ┃ ┃ ┣ cliutils
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ archive_viewer.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ bindepend.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ grab_version.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ makespec.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ set_version.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ archive_viewer.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ bindepend.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ grab_version.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ makespec.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ set_version.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ hooks
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ subproc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ django_import_finder.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ django_import_finder.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ conda.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ django.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ gi.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ qt.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ tcl_tk.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ win32.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ conda.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ django.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ gi.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ qt.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ tcl_tk.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ win32.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ win32
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ icon.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ versioninfo.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ winmanifest.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ winresource.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ winutils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ icon.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ versioninfo.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ winmanifest.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ winresource.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ winutils.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ git.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ misc.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ osx.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ release.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ run_tests.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ tests.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _gitrevision.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ conftest.py
 ┃ ┃ ┃ ┃ ┃ ┣ git.py
 ┃ ┃ ┃ ┃ ┃ ┣ misc.py
 ┃ ┃ ┃ ┃ ┃ ┣ osx.py
 ┃ ┃ ┃ ┃ ┃ ┣ release.py
 ┃ ┃ ┃ ┃ ┃ ┣ run_tests.py
 ┃ ┃ ┃ ┃ ┃ ┣ tests.py
 ┃ ┃ ┃ ┃ ┃ ┣ _gitrevision.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┣ compat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ config.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ configure.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ exceptions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ log.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _recursion_to_deep_message.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _shared_with_waf.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┗ __main__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┣ compat.py
 ┃ ┃ ┃ ┃ ┣ config.py
 ┃ ┃ ┃ ┃ ┣ configure.py
 ┃ ┃ ┃ ┃ ┣ exceptions.py
 ┃ ┃ ┃ ┃ ┣ log.py
 ┃ ┃ ┃ ┃ ┣ _recursion_to_deep_message.py
 ┃ ┃ ┃ ┃ ┣ _shared_with_waf.py
 ┃ ┃ ┃ ┃ ┣ __init__.py
 ┃ ┃ ┃ ┃ ┗ __main__.py
 ┃ ┃ ┃ ┣ pyinstaller-4.10.dist-info
 ┃ ┃ ┃ ┃ ┣ COPYING.txt
 ┃ ┃ ┃ ┃ ┣ entry_points.txt
 ┃ ┃ ┃ ┃ ┣ INSTALLER
 ┃ ┃ ┃ ┃ ┣ METADATA
 ┃ ┃ ┃ ┃ ┣ RECORD
 ┃ ┃ ┃ ┃ ┣ REQUESTED
 ┃ ┃ ┃ ┃ ┣ top_level.txt
 ┃ ┃ ┃ ┃ ┗ WHEEL
 ┃ ┃ ┃ ┣ pyinstaller_hooks_contrib-2022.3.dist-info
 ┃ ┃ ┃ ┃ ┣ entry_points.txt
 ┃ ┃ ┃ ┃ ┣ INSTALLER
 ┃ ┃ ┃ ┃ ┣ LICENSE
 ┃ ┃ ┃ ┃ ┣ LICENSE.APL.txt
 ┃ ┃ ┃ ┃ ┣ LICENSE.GPL.txt
 ┃ ┃ ┃ ┃ ┣ METADATA
 ┃ ┃ ┃ ┃ ┣ RECORD
 ┃ ┃ ┃ ┃ ┣ top_level.txt
 ┃ ┃ ┃ ┃ ┗ WHEEL
 ┃ ┃ ┃ ┣ pypng-0.0.21.dist-info
 ┃ ┃ ┃ ┃ ┣ INSTALLER
 ┃ ┃ ┃ ┃ ┣ LICENCE
 ┃ ┃ ┃ ┃ ┣ METADATA
 ┃ ┃ ┃ ┃ ┣ RECORD
 ┃ ┃ ┃ ┃ ┣ REQUESTED
 ┃ ┃ ┃ ┃ ┣ top_level.txt
 ┃ ┃ ┃ ┃ ┗ WHEEL
 ┃ ┃ ┃ ┣ pyqrcode
 ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┣ builder.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ tables.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┣ builder.py
 ┃ ┃ ┃ ┃ ┣ tables.py
 ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┣ PyQRCode-1.2.1.dist-info
 ┃ ┃ ┃ ┃ ┣ INSTALLER
 ┃ ┃ ┃ ┃ ┣ METADATA
 ┃ ┃ ┃ ┃ ┣ RECORD
 ┃ ┃ ┃ ┃ ┣ REQUESTED
 ┃ ┃ ┃ ┃ ┣ top_level.txt
 ┃ ┃ ┃ ┃ ┗ WHEEL
 ┃ ┃ ┃ ┣ python_dateutil-2.8.2.dist-info
 ┃ ┃ ┃ ┃ ┣ INSTALLER
 ┃ ┃ ┃ ┃ ┣ LICENSE
 ┃ ┃ ┃ ┃ ┣ METADATA
 ┃ ┃ ┃ ┃ ┣ RECORD
 ┃ ┃ ┃ ┃ ┣ top_level.txt
 ┃ ┃ ┃ ┃ ┣ WHEEL
 ┃ ┃ ┃ ┃ ┗ zip-safe
 ┃ ┃ ┃ ┣ pytz
 ┃ ┃ ┃ ┃ ┣ zoneinfo
 ┃ ┃ ┃ ┃ ┃ ┣ Africa
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Abidjan
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Accra
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Addis_Ababa
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Algiers
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Asmara
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Asmera
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Bamako
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Bangui
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Banjul
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Bissau
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Blantyre
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Brazzaville
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Bujumbura
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Cairo
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Casablanca
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Ceuta
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Conakry
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Dakar
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Dar_es_Salaam
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Djibouti
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Douala
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ El_Aaiun
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Freetown
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Gaborone
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Harare
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Johannesburg
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Juba
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Kampala
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Khartoum
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Kigali
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Kinshasa
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Lagos
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Libreville
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Lome
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Luanda
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Lubumbashi
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Lusaka
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Malabo
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Maputo
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Maseru
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Mbabane
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Mogadishu
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Monrovia
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Nairobi
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Ndjamena
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Niamey
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Nouakchott
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Ouagadougou
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Porto-Novo
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Sao_Tome
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Timbuktu
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Tripoli
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Tunis
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ Windhoek
 ┃ ┃ ┃ ┃ ┃ ┣ America
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Argentina
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ Buenos_Aires
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ Catamarca
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ ComodRivadavia
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ Cordoba
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ Jujuy
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ La_Rioja
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ Mendoza
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ Rio_Gallegos
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ Salta
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ San_Juan
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ San_Luis
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ Tucuman
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ Ushuaia
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Indiana
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ Indianapolis
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ Knox
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ Marengo
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ Petersburg
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ Tell_City
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ Vevay
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ Vincennes
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ Winamac
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Kentucky
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ Louisville
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ Monticello
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ North_Dakota
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ Beulah
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ Center
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ New_Salem
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Adak
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Anchorage
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Anguilla
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Antigua
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Araguaina
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Aruba
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Asuncion
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Atikokan
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Atka
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Bahia
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Bahia_Banderas
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Barbados
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Belem
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Belize
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Blanc-Sablon
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Boa_Vista
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Bogota
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Boise
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Buenos_Aires
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Cambridge_Bay
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Campo_Grande
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Cancun
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Caracas
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Catamarca
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Cayenne
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Cayman
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Chicago
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Chihuahua
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Coral_Harbour
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Cordoba
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Costa_Rica
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Creston
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Cuiaba
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Curacao
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Danmarkshavn
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Dawson
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Dawson_Creek
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Denver
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Detroit
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Dominica
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Edmonton
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Eirunepe
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ El_Salvador
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Ensenada
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Fortaleza
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Fort_Nelson
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Fort_Wayne
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Glace_Bay
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Godthab
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Goose_Bay
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Grand_Turk
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Grenada
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Guadeloupe
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Guatemala
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Guayaquil
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Guyana
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Halifax
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Havana
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Hermosillo
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Indianapolis
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Inuvik
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Iqaluit
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Jamaica
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Jujuy
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Juneau
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Knox_IN
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Kralendijk
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ La_Paz
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Lima
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Los_Angeles
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Louisville
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Lower_Princes
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Maceio
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Managua
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Manaus
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Marigot
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Martinique
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Matamoros
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Mazatlan
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Mendoza
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Menominee
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Merida
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Metlakatla
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Mexico_City
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Miquelon
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Moncton
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Monterrey
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Montevideo
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Montreal
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Montserrat
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Nassau
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ New_York
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Nipigon
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Nome
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Noronha
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Nuuk
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Ojinaga
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Panama
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Pangnirtung
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Paramaribo
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Phoenix
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Port-au-Prince
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Porto_Acre
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Porto_Velho
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Port_of_Spain
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Puerto_Rico
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Punta_Arenas
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Rainy_River
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Rankin_Inlet
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Recife
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Regina
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Resolute
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Rio_Branco
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Rosario
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Santarem
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Santa_Isabel
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Santiago
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Santo_Domingo
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Sao_Paulo
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Scoresbysund
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Shiprock
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Sitka
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ St_Barthelemy
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ St_Johns
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ St_Kitts
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ St_Lucia
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ St_Thomas
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ St_Vincent
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Swift_Current
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Tegucigalpa
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Thule
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Thunder_Bay
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Tijuana
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Toronto
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Tortola
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Vancouver
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Virgin
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Whitehorse
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Winnipeg
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Yakutat
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ Yellowknife
 ┃ ┃ ┃ ┃ ┃ ┣ Antarctica
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Casey
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Davis
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ DumontDUrville
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Macquarie
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Mawson
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ McMurdo
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Palmer
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Rothera
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ South_Pole
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Syowa
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Troll
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ Vostok
 ┃ ┃ ┃ ┃ ┃ ┣ Arctic
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ Longyearbyen
 ┃ ┃ ┃ ┃ ┃ ┣ Asia
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Aden
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Almaty
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Amman
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Anadyr
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Aqtau
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Aqtobe
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Ashgabat
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Ashkhabad
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Atyrau
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Baghdad
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Bahrain
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Baku
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Bangkok
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Barnaul
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Beirut
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Bishkek
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Brunei
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Calcutta
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Chita
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Choibalsan
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Chongqing
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Chungking
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Colombo
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Dacca
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Damascus
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Dhaka
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Dili
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Dubai
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Dushanbe
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Famagusta
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Gaza
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Harbin
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Hebron
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Hong_Kong
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Hovd
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Ho_Chi_Minh
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Irkutsk
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Istanbul
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Jakarta
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Jayapura
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Jerusalem
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Kabul
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Kamchatka
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Karachi
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Kashgar
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Kathmandu
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Katmandu
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Khandyga
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Kolkata
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Krasnoyarsk
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Kuala_Lumpur
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Kuching
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Kuwait
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Macao
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Macau
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Magadan
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Makassar
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Manila
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Muscat
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Nicosia
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Novokuznetsk
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Novosibirsk
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Omsk
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Oral
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Phnom_Penh
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Pontianak
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Pyongyang
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Qatar
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Qostanay
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Qyzylorda
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Rangoon
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Riyadh
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Saigon
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Sakhalin
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Samarkand
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Seoul
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Shanghai
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Singapore
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Srednekolymsk
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Taipei
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Tashkent
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Tbilisi
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Tehran
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Tel_Aviv
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Thimbu
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Thimphu
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Tokyo
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Tomsk
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Ujung_Pandang
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Ulaanbaatar
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Ulan_Bator
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Urumqi
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Ust-Nera
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Vientiane
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Vladivostok
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Yakutsk
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Yangon
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Yekaterinburg
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ Yerevan
 ┃ ┃ ┃ ┃ ┃ ┣ Atlantic
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Azores
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Bermuda
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Canary
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Cape_Verde
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Faeroe
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Faroe
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Jan_Mayen
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Madeira
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Reykjavik
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ South_Georgia
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Stanley
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ St_Helena
 ┃ ┃ ┃ ┃ ┃ ┣ Australia
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ ACT
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Adelaide
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Brisbane
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Broken_Hill
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Canberra
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Currie
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Darwin
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Eucla
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Hobart
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ LHI
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Lindeman
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Lord_Howe
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Melbourne
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ North
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ NSW
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Perth
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Queensland
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ South
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Sydney
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Tasmania
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Victoria
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ West
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ Yancowinna
 ┃ ┃ ┃ ┃ ┃ ┣ Brazil
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Acre
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ DeNoronha
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ East
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ West
 ┃ ┃ ┃ ┃ ┃ ┣ Canada
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Atlantic
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Central
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Eastern
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Mountain
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Newfoundland
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Pacific
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Saskatchewan
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ Yukon
 ┃ ┃ ┃ ┃ ┃ ┣ Chile
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Continental
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ EasterIsland
 ┃ ┃ ┃ ┃ ┃ ┣ Etc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ GMT
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ GMT+0
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ GMT+1
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ GMT+10
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ GMT+11
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ GMT+12
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ GMT+2
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ GMT+3
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ GMT+4
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ GMT+5
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ GMT+6
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ GMT+7
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ GMT+8
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ GMT+9
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ GMT-0
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ GMT-1
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ GMT-10
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ GMT-11
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ GMT-12
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ GMT-13
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ GMT-14
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ GMT-2
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ GMT-3
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ GMT-4
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ GMT-5
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ GMT-6
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ GMT-7
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ GMT-8
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ GMT-9
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ GMT0
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Greenwich
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ UCT
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Universal
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ UTC
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ Zulu
 ┃ ┃ ┃ ┃ ┃ ┣ Europe
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Amsterdam
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Andorra
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Astrakhan
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Athens
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Belfast
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Belgrade
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Berlin
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Bratislava
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Brussels
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Bucharest
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Budapest
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Busingen
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Chisinau
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Copenhagen
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Dublin
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Gibraltar
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Guernsey
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Helsinki
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Isle_of_Man
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Istanbul
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Jersey
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Kaliningrad
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Kiev
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Kirov
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Lisbon
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Ljubljana
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ London
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Luxembourg
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Madrid
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Malta
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Mariehamn
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Minsk
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Monaco
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Moscow
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Nicosia
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Oslo
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Paris
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Podgorica
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Prague
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Riga
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Rome
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Samara
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ San_Marino
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Sarajevo
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Saratov
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Simferopol
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Skopje
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Sofia
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Stockholm
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Tallinn
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Tirane
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Tiraspol
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Ulyanovsk
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Uzhgorod
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Vaduz
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Vatican
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Vienna
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Vilnius
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Volgograd
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Warsaw
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Zagreb
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Zaporozhye
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ Zurich
 ┃ ┃ ┃ ┃ ┃ ┣ Indian
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Antananarivo
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Chagos
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Christmas
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Cocos
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Comoro
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Kerguelen
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Mahe
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Maldives
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Mauritius
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Mayotte
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ Reunion
 ┃ ┃ ┃ ┃ ┃ ┣ Mexico
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ BajaNorte
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ BajaSur
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ General
 ┃ ┃ ┃ ┃ ┃ ┣ Pacific
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Apia
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Auckland
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Bougainville
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Chatham
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Chuuk
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Easter
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Efate
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Enderbury
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Fakaofo
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Fiji
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Funafuti
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Galapagos
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Gambier
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Guadalcanal
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Guam
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Honolulu
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Johnston
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Kanton
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Kiritimati
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Kosrae
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Kwajalein
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Majuro
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Marquesas
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Midway
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Nauru
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Niue
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Norfolk
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Noumea
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Pago_Pago
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Palau
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Pitcairn
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Pohnpei
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Ponape
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Port_Moresby
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Rarotonga
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Saipan
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Samoa
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Tahiti
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Tarawa
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Tongatapu
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Truk
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Wake
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Wallis
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ Yap
 ┃ ┃ ┃ ┃ ┃ ┣ US
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Alaska
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Aleutian
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Arizona
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Central
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ East-Indiana
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Eastern
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Hawaii
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Indiana-Starke
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Michigan
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Mountain
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ Pacific
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ Samoa
 ┃ ┃ ┃ ┃ ┃ ┣ CET
 ┃ ┃ ┃ ┃ ┃ ┣ CST6CDT
 ┃ ┃ ┃ ┃ ┃ ┣ Cuba
 ┃ ┃ ┃ ┃ ┃ ┣ EET
 ┃ ┃ ┃ ┃ ┃ ┣ Egypt
 ┃ ┃ ┃ ┃ ┃ ┣ Eire
 ┃ ┃ ┃ ┃ ┃ ┣ EST
 ┃ ┃ ┃ ┃ ┃ ┣ EST5EDT
 ┃ ┃ ┃ ┃ ┃ ┣ Factory
 ┃ ┃ ┃ ┃ ┃ ┣ GB
 ┃ ┃ ┃ ┃ ┃ ┣ GB-Eire
 ┃ ┃ ┃ ┃ ┃ ┣ GMT
 ┃ ┃ ┃ ┃ ┃ ┣ GMT+0
 ┃ ┃ ┃ ┃ ┃ ┣ GMT-0
 ┃ ┃ ┃ ┃ ┃ ┣ GMT0
 ┃ ┃ ┃ ┃ ┃ ┣ Greenwich
 ┃ ┃ ┃ ┃ ┃ ┣ Hongkong
 ┃ ┃ ┃ ┃ ┃ ┣ HST
 ┃ ┃ ┃ ┃ ┃ ┣ Iceland
 ┃ ┃ ┃ ┃ ┃ ┣ Iran
 ┃ ┃ ┃ ┃ ┃ ┣ iso3166.tab
 ┃ ┃ ┃ ┃ ┃ ┣ Israel
 ┃ ┃ ┃ ┃ ┃ ┣ Jamaica
 ┃ ┃ ┃ ┃ ┃ ┣ Japan
 ┃ ┃ ┃ ┃ ┃ ┣ Kwajalein
 ┃ ┃ ┃ ┃ ┃ ┣ leapseconds
 ┃ ┃ ┃ ┃ ┃ ┣ Libya
 ┃ ┃ ┃ ┃ ┃ ┣ MET
 ┃ ┃ ┃ ┃ ┃ ┣ MST
 ┃ ┃ ┃ ┃ ┃ ┣ MST7MDT
 ┃ ┃ ┃ ┃ ┃ ┣ Navajo
 ┃ ┃ ┃ ┃ ┃ ┣ NZ
 ┃ ┃ ┃ ┃ ┃ ┣ NZ-CHAT
 ┃ ┃ ┃ ┃ ┃ ┣ Poland
 ┃ ┃ ┃ ┃ ┃ ┣ Portugal
 ┃ ┃ ┃ ┃ ┃ ┣ PRC
 ┃ ┃ ┃ ┃ ┃ ┣ PST8PDT
 ┃ ┃ ┃ ┃ ┃ ┣ ROC
 ┃ ┃ ┃ ┃ ┃ ┣ ROK
 ┃ ┃ ┃ ┃ ┃ ┣ Singapore
 ┃ ┃ ┃ ┃ ┃ ┣ Turkey
 ┃ ┃ ┃ ┃ ┃ ┣ tzdata.zi
 ┃ ┃ ┃ ┃ ┃ ┣ UCT
 ┃ ┃ ┃ ┃ ┃ ┣ Universal
 ┃ ┃ ┃ ┃ ┃ ┣ UTC
 ┃ ┃ ┃ ┃ ┃ ┣ W-SU
 ┃ ┃ ┃ ┃ ┃ ┣ WET
 ┃ ┃ ┃ ┃ ┃ ┣ zone.tab
 ┃ ┃ ┃ ┃ ┃ ┣ zone1970.tab
 ┃ ┃ ┃ ┃ ┃ ┗ Zulu
 ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┣ exceptions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ lazy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ reference.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ tzfile.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ tzinfo.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┣ exceptions.py
 ┃ ┃ ┃ ┃ ┣ lazy.py
 ┃ ┃ ┃ ┃ ┣ reference.py
 ┃ ┃ ┃ ┃ ┣ tzfile.py
 ┃ ┃ ┃ ┃ ┣ tzinfo.py
 ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┣ pytz-2021.3.dist-info
 ┃ ┃ ┃ ┃ ┣ INSTALLER
 ┃ ┃ ┃ ┃ ┣ LICENSE.txt
 ┃ ┃ ┃ ┃ ┣ METADATA
 ┃ ┃ ┃ ┃ ┣ RECORD
 ┃ ┃ ┃ ┃ ┣ top_level.txt
 ┃ ┃ ┃ ┃ ┣ WHEEL
 ┃ ┃ ┃ ┃ ┗ zip-safe
 ┃ ┃ ┃ ┣ pywin32_ctypes-0.2.0.dist-info
 ┃ ┃ ┃ ┃ ┣ INSTALLER
 ┃ ┃ ┃ ┃ ┣ LICENSE.txt
 ┃ ┃ ┃ ┃ ┣ METADATA
 ┃ ┃ ┃ ┃ ┣ RECORD
 ┃ ┃ ┃ ┃ ┣ top_level.txt
 ┃ ┃ ┃ ┃ ┗ WHEEL
 ┃ ┃ ┃ ┣ pyzbar
 ┃ ┃ ┃ ┃ ┣ scripts
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ read_zbar.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ read_zbar.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ tests
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_locations.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_pyzbar.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_read_zbar.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_zbar_library.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ code128.png
 ┃ ┃ ┃ ┃ ┃ ┣ empty.png
 ┃ ┃ ┃ ┃ ┃ ┣ qrcode.png
 ┃ ┃ ┃ ┃ ┃ ┣ qrcode_rotated.png
 ┃ ┃ ┃ ┃ ┃ ┣ test_locations.py
 ┃ ┃ ┃ ┃ ┃ ┣ test_pyzbar.py
 ┃ ┃ ┃ ┃ ┃ ┣ test_read_zbar.py
 ┃ ┃ ┃ ┃ ┃ ┣ test_zbar_library.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┣ locations.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ pyzbar.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ pyzbar_error.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ wrapper.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ zbar_library.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┣ libiconv.dll
 ┃ ┃ ┃ ┃ ┣ libzbar-64.dll
 ┃ ┃ ┃ ┃ ┣ locations.py
 ┃ ┃ ┃ ┃ ┣ pyzbar.py
 ┃ ┃ ┃ ┃ ┣ pyzbar_error.py
 ┃ ┃ ┃ ┃ ┣ wrapper.py
 ┃ ┃ ┃ ┃ ┣ zbar-LICENSE.txt
 ┃ ┃ ┃ ┃ ┣ zbar_library.py
 ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┣ pyzbar-0.1.8.dist-info
 ┃ ┃ ┃ ┃ ┣ entry_points.txt
 ┃ ┃ ┃ ┃ ┣ INSTALLER
 ┃ ┃ ┃ ┃ ┣ LICENSE.txt
 ┃ ┃ ┃ ┃ ┣ METADATA
 ┃ ┃ ┃ ┃ ┣ RECORD
 ┃ ┃ ┃ ┃ ┣ REQUESTED
 ┃ ┃ ┃ ┃ ┣ top_level.txt
 ┃ ┃ ┃ ┃ ┗ WHEEL
 ┃ ┃ ┃ ┣ setuptools
 ┃ ┃ ┃ ┃ ┣ command
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ bdist_egg.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ build_ext.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ build_py.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ easy_install.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ egg_info.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ install.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ install_egg_info.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ install_lib.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ install_scripts.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ py36compat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ sdist.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ setopt.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ alias.py
 ┃ ┃ ┃ ┃ ┃ ┣ bdist_egg.py
 ┃ ┃ ┃ ┃ ┃ ┣ bdist_rpm.py
 ┃ ┃ ┃ ┃ ┃ ┣ build_clib.py
 ┃ ┃ ┃ ┃ ┃ ┣ build_ext.py
 ┃ ┃ ┃ ┃ ┃ ┣ build_py.py
 ┃ ┃ ┃ ┃ ┃ ┣ develop.py
 ┃ ┃ ┃ ┃ ┃ ┣ dist_info.py
 ┃ ┃ ┃ ┃ ┃ ┣ easy_install.py
 ┃ ┃ ┃ ┃ ┃ ┣ egg_info.py
 ┃ ┃ ┃ ┃ ┃ ┣ install.py
 ┃ ┃ ┃ ┃ ┃ ┣ install_egg_info.py
 ┃ ┃ ┃ ┃ ┃ ┣ install_lib.py
 ┃ ┃ ┃ ┃ ┃ ┣ install_scripts.py
 ┃ ┃ ┃ ┃ ┃ ┣ launcher manifest.xml
 ┃ ┃ ┃ ┃ ┃ ┣ py36compat.py
 ┃ ┃ ┃ ┃ ┃ ┣ register.py
 ┃ ┃ ┃ ┃ ┃ ┣ rotate.py
 ┃ ┃ ┃ ┃ ┃ ┣ saveopts.py
 ┃ ┃ ┃ ┃ ┃ ┣ sdist.py
 ┃ ┃ ┃ ┃ ┃ ┣ setopt.py
 ┃ ┃ ┃ ┃ ┃ ┣ test.py
 ┃ ┃ ┃ ┃ ┃ ┣ upload.py
 ┃ ┃ ┃ ┃ ┃ ┣ upload_docs.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ extern
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ _distutils
 ┃ ┃ ┃ ┃ ┃ ┣ command
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ bdist.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ bdist_dumb.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ bdist_msi.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ bdist_rpm.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ bdist_wininst.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ build.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ build_clib.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ build_ext.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ build_py.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ build_scripts.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ check.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ clean.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ config.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ install.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ install_data.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ install_egg_info.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ install_headers.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ install_lib.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ install_scripts.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ py37compat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ register.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ sdist.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ upload.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ archive_util.py
 ┃ ┃ ┃ ┃ ┃ ┣ bcppcompiler.py
 ┃ ┃ ┃ ┃ ┃ ┣ ccompiler.py
 ┃ ┃ ┃ ┃ ┃ ┣ cmd.py
 ┃ ┃ ┃ ┃ ┃ ┣ config.py
 ┃ ┃ ┃ ┃ ┃ ┣ core.py
 ┃ ┃ ┃ ┃ ┃ ┣ cygwinccompiler.py
 ┃ ┃ ┃ ┃ ┃ ┣ debug.py
 ┃ ┃ ┃ ┃ ┃ ┣ dep_util.py
 ┃ ┃ ┃ ┃ ┃ ┣ dir_util.py
 ┃ ┃ ┃ ┃ ┃ ┣ dist.py
 ┃ ┃ ┃ ┃ ┃ ┣ errors.py
 ┃ ┃ ┃ ┃ ┃ ┣ extension.py
 ┃ ┃ ┃ ┃ ┃ ┣ fancy_getopt.py
 ┃ ┃ ┃ ┃ ┃ ┣ filelist.py
 ┃ ┃ ┃ ┃ ┃ ┣ file_util.py
 ┃ ┃ ┃ ┃ ┃ ┣ log.py
 ┃ ┃ ┃ ┃ ┃ ┣ msvc9compiler.py
 ┃ ┃ ┃ ┃ ┃ ┣ msvccompiler.py
 ┃ ┃ ┃ ┃ ┃ ┣ py35compat.py
 ┃ ┃ ┃ ┃ ┃ ┣ py38compat.py
 ┃ ┃ ┃ ┃ ┃ ┣ spawn.py
 ┃ ┃ ┃ ┃ ┃ ┣ sysconfig.py
 ┃ ┃ ┃ ┃ ┃ ┣ text_file.py
 ┃ ┃ ┃ ┃ ┃ ┣ unixccompiler.py
 ┃ ┃ ┃ ┃ ┃ ┣ util.py
 ┃ ┃ ┃ ┃ ┃ ┣ version.py
 ┃ ┃ ┃ ┃ ┃ ┣ versionpredicate.py
 ┃ ┃ ┃ ┃ ┃ ┣ _msvccompiler.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ _vendor
 ┃ ┃ ┃ ┃ ┃ ┣ more_itertools
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ more.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ recipes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ more.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ recipes.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ packaging
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ specifiers.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ tags.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ utils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ version.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _compat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _structures.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _typing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __about__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ markers.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ requirements.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ specifiers.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ tags.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ utils.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ version.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _compat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _structures.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _typing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __about__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ ordered_set.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ ordered_set.py
 ┃ ┃ ┃ ┃ ┃ ┣ pyparsing.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┣ archive_util.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ config.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ depends.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ dist.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ extension.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ glob.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ lib2to3_ex.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ monkey.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ msvc.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ namespaces.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ package_index.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ py34compat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ sandbox.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ ssl_support.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ unicode_utils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ version.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ wheel.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ windows_support.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _deprecation_warning.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ _imp.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┣ archive_util.py
 ┃ ┃ ┃ ┃ ┣ build_meta.py
 ┃ ┃ ┃ ┃ ┣ cli-32.exe
 ┃ ┃ ┃ ┃ ┣ cli-64.exe
 ┃ ┃ ┃ ┃ ┣ cli.exe
 ┃ ┃ ┃ ┃ ┣ config.py
 ┃ ┃ ┃ ┃ ┣ depends.py
 ┃ ┃ ┃ ┃ ┣ dep_util.py
 ┃ ┃ ┃ ┃ ┣ dist.py
 ┃ ┃ ┃ ┃ ┣ errors.py
 ┃ ┃ ┃ ┃ ┣ extension.py
 ┃ ┃ ┃ ┃ ┣ glob.py
 ┃ ┃ ┃ ┃ ┣ gui-32.exe
 ┃ ┃ ┃ ┃ ┣ gui-64.exe
 ┃ ┃ ┃ ┃ ┣ gui.exe
 ┃ ┃ ┃ ┃ ┣ installer.py
 ┃ ┃ ┃ ┃ ┣ launch.py
 ┃ ┃ ┃ ┃ ┣ lib2to3_ex.py
 ┃ ┃ ┃ ┃ ┣ monkey.py
 ┃ ┃ ┃ ┃ ┣ msvc.py
 ┃ ┃ ┃ ┃ ┣ namespaces.py
 ┃ ┃ ┃ ┃ ┣ package_index.py
 ┃ ┃ ┃ ┃ ┣ py34compat.py
 ┃ ┃ ┃ ┃ ┣ sandbox.py
 ┃ ┃ ┃ ┃ ┣ script (dev).tmpl
 ┃ ┃ ┃ ┃ ┣ script.tmpl
 ┃ ┃ ┃ ┃ ┣ ssl_support.py
 ┃ ┃ ┃ ┃ ┣ unicode_utils.py
 ┃ ┃ ┃ ┃ ┣ version.py
 ┃ ┃ ┃ ┃ ┣ wheel.py
 ┃ ┃ ┃ ┃ ┣ windows_support.py
 ┃ ┃ ┃ ┃ ┣ _deprecation_warning.py
 ┃ ┃ ┃ ┃ ┣ _imp.py
 ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┣ setuptools-57.0.0.dist-info
 ┃ ┃ ┃ ┃ ┣ dependency_links.txt
 ┃ ┃ ┃ ┃ ┣ entry_points.txt
 ┃ ┃ ┃ ┃ ┣ INSTALLER
 ┃ ┃ ┃ ┃ ┣ LICENSE
 ┃ ┃ ┃ ┃ ┣ METADATA
 ┃ ┃ ┃ ┃ ┣ RECORD
 ┃ ┃ ┃ ┃ ┣ top_level.txt
 ┃ ┃ ┃ ┃ ┗ WHEEL
 ┃ ┃ ┃ ┣ six-1.16.0.dist-info
 ┃ ┃ ┃ ┃ ┣ INSTALLER
 ┃ ┃ ┃ ┃ ┣ LICENSE
 ┃ ┃ ┃ ┃ ┣ METADATA
 ┃ ┃ ┃ ┃ ┣ RECORD
 ┃ ┃ ┃ ┃ ┣ top_level.txt
 ┃ ┃ ┃ ┃ ┗ WHEEL
 ┃ ┃ ┃ ┣ wheel
 ┃ ┃ ┃ ┃ ┣ cli
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ convert.py
 ┃ ┃ ┃ ┃ ┃ ┣ pack.py
 ┃ ┃ ┃ ┃ ┃ ┣ unpack.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ vendored
 ┃ ┃ ┃ ┃ ┃ ┣ packaging
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ tags.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _typing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ tags.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _typing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┣ bdist_wheel.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ macosx_libfile.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ metadata.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ pkginfo.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ util.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ wheelfile.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┣ bdist_wheel.py
 ┃ ┃ ┃ ┃ ┣ macosx_libfile.py
 ┃ ┃ ┃ ┃ ┣ metadata.py
 ┃ ┃ ┃ ┃ ┣ pkginfo.py
 ┃ ┃ ┃ ┃ ┣ util.py
 ┃ ┃ ┃ ┃ ┣ wheelfile.py
 ┃ ┃ ┃ ┃ ┣ __init__.py
 ┃ ┃ ┃ ┃ ┗ __main__.py
 ┃ ┃ ┃ ┣ wheel-0.36.2.dist-info
 ┃ ┃ ┃ ┃ ┣ entry_points.txt
 ┃ ┃ ┃ ┃ ┣ INSTALLER
 ┃ ┃ ┃ ┃ ┣ LICENSE.txt
 ┃ ┃ ┃ ┃ ┣ METADATA
 ┃ ┃ ┃ ┃ ┣ RECORD
 ┃ ┃ ┃ ┃ ┣ top_level.txt
 ┃ ┃ ┃ ┃ ┗ WHEEL
 ┃ ┃ ┃ ┣ whichcraft-0.6.1.dist-info
 ┃ ┃ ┃ ┃ ┣ AUTHORS.rst
 ┃ ┃ ┃ ┃ ┣ INSTALLER
 ┃ ┃ ┃ ┃ ┣ LICENSE
 ┃ ┃ ┃ ┃ ┣ METADATA
 ┃ ┃ ┃ ┃ ┣ RECORD
 ┃ ┃ ┃ ┃ ┣ top_level.txt
 ┃ ┃ ┃ ┃ ┗ WHEEL
 ┃ ┃ ┃ ┣ win32ctypes
 ┃ ┃ ┃ ┃ ┣ core
 ┃ ┃ ┃ ┃ ┃ ┣ cffi
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _authentication.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _common.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _dll.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _nl_support.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _resource.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _system_information.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _time.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _util.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _authentication.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _common.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _dll.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _nl_support.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _resource.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _system_information.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _time.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _util.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ ctypes
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _authentication.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _common.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _dll.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _nl_support.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _resource.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _system_information.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _time.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ _util.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _authentication.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _common.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _dll.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _nl_support.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _resource.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _system_information.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _time.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _util.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ compat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _winerrors.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ compat.py
 ┃ ┃ ┃ ┃ ┃ ┣ _winerrors.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ pywin32
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pywintypes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ win32api.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ win32cred.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ pywintypes.py
 ┃ ┃ ┃ ┃ ┃ ┣ win32api.py
 ┃ ┃ ┃ ┃ ┃ ┣ win32cred.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ tests
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ compat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_win32api.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_win32cred.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ compat.py
 ┃ ┃ ┃ ┃ ┃ ┣ test_win32api.py
 ┃ ┃ ┃ ┃ ┃ ┣ test_win32cred.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┣ pywintypes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ version.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ win32api.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ win32cred.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┣ pywintypes.py
 ┃ ┃ ┃ ┃ ┣ version.py
 ┃ ┃ ┃ ┃ ┣ win32api.py
 ┃ ┃ ┃ ┃ ┣ win32cred.py
 ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┣ zope
 ┃ ┃ ┃ ┃ ┣ event
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ classhandler.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ tests.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ classhandler.py
 ┃ ┃ ┃ ┃ ┃ ┣ tests.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┗ interface
 ┃ ┃ ┃ ┃ ┃ ┣ common
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ tests
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ basemapping.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_builtins.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_collections.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_idatetime.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_import_interfaces.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_io.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_numbers.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ basemapping.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_builtins.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_collections.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_idatetime.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_import_interfaces.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_io.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_numbers.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ builtins.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ collections.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ idatetime.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ interfaces.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ io.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ mapping.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ numbers.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ sequence.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ builtins.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ collections.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ idatetime.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ interfaces.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ io.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ mapping.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ numbers.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ sequence.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ tests
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ advisory_testing.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ dummy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ idummy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ m1.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ odd.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_adapter.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_advice.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_declarations.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_document.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_element.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_exceptions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_interface.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_interfaces.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_odd_declarations.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_registry.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_ro.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_sorting.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_verify.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ advisory_testing.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ dummy.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ idummy.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ m1.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ odd.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_adapter.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_advice.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_declarations.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_document.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_element.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_exceptions.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_interface.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_interfaces.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_odd_declarations.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_registry.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_ro.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_sorting.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_verify.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ adapter.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ advice.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ declarations.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ document.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ exceptions.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ interface.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ interfaces.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ registry.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ ro.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ verify.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _compat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ _flatten.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ adapter.py
 ┃ ┃ ┃ ┃ ┃ ┣ advice.py
 ┃ ┃ ┃ ┃ ┃ ┣ declarations.py
 ┃ ┃ ┃ ┃ ┃ ┣ document.py
 ┃ ┃ ┃ ┃ ┃ ┣ exceptions.py
 ┃ ┃ ┃ ┃ ┃ ┣ interface.py
 ┃ ┃ ┃ ┃ ┃ ┣ interfaces.py
 ┃ ┃ ┃ ┃ ┃ ┣ registry.py
 ┃ ┃ ┃ ┃ ┃ ┣ ro.py
 ┃ ┃ ┃ ┃ ┃ ┣ verify.py
 ┃ ┃ ┃ ┃ ┃ ┣ _compat.py
 ┃ ┃ ┃ ┃ ┃ ┣ _flatten.py
 ┃ ┃ ┃ ┃ ┃ ┣ _zope_interface_coptimizations.c
 ┃ ┃ ┃ ┃ ┃ ┣ _zope_interface_coptimizations.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┣ zope.event-4.5.0.dist-info
 ┃ ┃ ┃ ┃ ┣ INSTALLER
 ┃ ┃ ┃ ┃ ┣ LICENSE.txt
 ┃ ┃ ┃ ┃ ┣ METADATA
 ┃ ┃ ┃ ┃ ┣ namespace_packages.txt
 ┃ ┃ ┃ ┃ ┣ RECORD
 ┃ ┃ ┃ ┃ ┣ top_level.txt
 ┃ ┃ ┃ ┃ ┗ WHEEL
 ┃ ┃ ┃ ┣ zope.interface-5.4.0.dist-info
 ┃ ┃ ┃ ┃ ┣ INSTALLER
 ┃ ┃ ┃ ┃ ┣ LICENSE.txt
 ┃ ┃ ┃ ┃ ┣ METADATA
 ┃ ┃ ┃ ┃ ┣ namespace_packages.txt
 ┃ ┃ ┃ ┃ ┣ RECORD
 ┃ ┃ ┃ ┃ ┣ top_level.txt
 ┃ ┃ ┃ ┃ ┗ WHEEL
 ┃ ┃ ┃ ┣ _distutils_hack
 ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┣ override.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┣ override.py
 ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┣ _pyinstaller_hooks_contrib
 ┃ ┃ ┃ ┃ ┣ hooks
 ┃ ┃ ┃ ┃ ┃ ┣ pre_find_module_path
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ pre_safe_import_module
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-win32com.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-win32com.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ rthooks
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_enchant.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_nltk.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_osgeo.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_pygraphviz.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_pyproj.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_traitlets.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_usb.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_enchant.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_nltk.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_osgeo.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_pygraphviz.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_pyproj.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_traitlets.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_rth_usb.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ stdhooks
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-accessible_output2.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-adbutils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-adios.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-afmformats.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-aliyunsdkcore.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-altair.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-amazonproduct.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-anyio.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-appdirs.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-appy.pod.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-apscheduler.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-argon2.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-astor.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-astroid.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-astropy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-av.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-avro.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-azurerm.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-backports.zoneinfo.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-bacon.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-bcrypt.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-bleak.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-blspy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-bokeh.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-boto.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-boto3.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-botocore.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-branca.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-BTrees.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-cairocffi.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-cairosvg.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-cassandra.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-certifi.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-cloudscraper.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-clr.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-countrycode.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-countryinfo.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-Crypto.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-Cryptodome.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-cryptography.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-cv2.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-cx_Oracle.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-cytoolz.itertoolz.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-dash.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-dash_bootstrap_components.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-dash_core_components.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-dash_html_components.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-dash_renderer.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-dash_table.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-dash_uploader.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-dask.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-dateparser.utils.strptime.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-dclab.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-distorm3.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-dns.rdata.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-docutils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-docx.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-docx2pdf.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-dynaconf.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-eel.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-enchant.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-enzyme.parsers.ebml.core.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-eth_abi.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-eth_account.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-eth_hash.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-eth_keyfile.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-eth_utils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-fabric.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-faker.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-ffpyplayer.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-flask_compress.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-flask_restx.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-flex.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-flirpy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-fmpy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-folium.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gadfly.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gcloud.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gitlab.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gmplot.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gooey.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-google.api.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-google.api_core.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-google.cloud.bigquery.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-google.cloud.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-google.cloud.kms_v1.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-google.cloud.pubsub_v1.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-google.cloud.speech.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-google.cloud.storage.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-google.cloud.translate.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-googleapiclient.model.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gst._gst.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gtk.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-h5py.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-HtmlTestRunner.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-httplib2.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-humanize.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-ijson.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-imageio.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-imageio_ffmpeg.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-iminuit.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-IPython.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-jaraco.text.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-jedi.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-jinja2.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-jinxed.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-jira.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-jsonpath_rw_ext.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-jsonrpcserver.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-jsonschema.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-jupyterlab.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-kaleido.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-kinterbasdb.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-langcodes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-langdetect.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-lensfunpy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-libaudioverse.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-lightgbm.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-llvmlite.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-logilab.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-lxml.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-lxml.etree.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-lxml.isoschematron.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-lxml.objectify.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-lz4.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-magic.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-mako.codegen.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-mariadb.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-markdown.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-metpy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-migrate.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-mimesis.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-mnemonic.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-mpl_toolkits.basemap.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-msoffcrypto.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-nacl.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-names.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-nanite.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-nbconvert.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-nbdime.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-nbformat.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-ncclient.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-netCDF4.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-nltk.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-nnpy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-notebook.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-numba.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-office365.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-OpenGL.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-OpenGL_accelerate.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-openpyxl.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-orjson.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-osgeo.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-panel.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-parsedatetime.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-parso.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-passlib.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-paste.exceptions.reporter.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-patsy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pdfminer.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pendulum.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-phonenumbers.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pingouin.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pint.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pinyin.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-platformdirs.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-plotly.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-prettytable.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-psychopy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-psycopg2.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-publicsuffix2.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pubsub.core.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-puremagic.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-py.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyarrow.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pycountry.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pycparser.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pydantic.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pydivert.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyexcel-io.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyexcel-ods.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyexcel-ods3.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyexcel-odsr.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyexcel-xls.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyexcel-xlsx.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyexcel-xlsxw.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyexcel.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyexcelerate.Writer.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyexcel_io.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyexcel_ods.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyexcel_ods3.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyexcel_odsr.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyexcel_xls.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyexcel_xlsx.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyexcel_xlsxw.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pygraphviz.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pylint.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pymediainfo.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pymssql.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pynput.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyodbc.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyopencl.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyphen.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyppeteer.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyproj.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pypsexec.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pypylon.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyqtgraph.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pysnmp.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pystray.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pytest.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pythoncom.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyttsx.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyttsx3.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyviz_comms.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyvjoy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pywintypes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pywt.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-qtmodern.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-radicale.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-raven.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-rawpy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-rdflib.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-redmine.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-regex.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-reportlab.lib.utils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-reportlab.pdfbase._fontdata.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-resampy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-rpy2.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-rtree.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-sacremoses.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-selenium.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-sentry_sdk.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-shapely.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-shotgun_api3.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-skimage.feature.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-skimage.filters.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-skimage.graph.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-skimage.io.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-skimage.transform.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-sklearn.cluster.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-sklearn.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-sklearn.linear_model.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-sklearn.metrics.cluster.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-sklearn.neighbors.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-sklearn.tree.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-sklearn.utils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-sounddevice.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-soundfile.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-sound_lib.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-spacy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-speech_recognition.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-spnego.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-srsly.msgpack._packer.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-statsmodels.tsa.statespace.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-storm.database.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-sunpy.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-swagger_spec_validator.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-tableauhyperapi.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-tables.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-tcod.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-tensorflow.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-textdistance.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-text_unidecode.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-thinc.backends.numpy_ops.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-thinc.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-timezonefinder.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-tinycss2.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-torch.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-torchvision.ops.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-trimesh.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-ttkthemes.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-ttkwidgets.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-tzdata.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-u1db.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-umap.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-unidecode.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-uniseg.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-usb.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-uvicorn.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-uvloop.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-vtkpython.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-wavefile.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-weasyprint.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-web3.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-webassets.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-webrtcvad.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-websockets.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-webview.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-win32com.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-workflow.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-wx.lib.activex.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-wx.lib.pubsub.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-wx.xrc.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-Xlib.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-xml.dom.html.HTMLDocument.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-xml.sax.saxexts.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-xmldiff.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-xsge_gui.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-zeep.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-zmq.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-zoneinfo.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-_mssql.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-_mysql.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-accessible_output2.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-adbutils.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-adios.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-afmformats.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-aliyunsdkcore.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-altair.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-amazonproduct.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-anyio.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-appdirs.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-appy.pod.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-apscheduler.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-argon2.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-astor.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-astroid.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-astropy.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-av.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-avro.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-azurerm.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-backports.zoneinfo.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-bacon.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-bcrypt.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-bleak.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-blspy.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-bokeh.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-boto.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-boto3.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-botocore.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-branca.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-BTrees.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-cairocffi.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-cairosvg.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-cassandra.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-certifi.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-cloudscraper.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-clr.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-countrycode.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-countryinfo.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-Crypto.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-Cryptodome.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-cryptography.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-cv2.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-cx_Oracle.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-cytoolz.itertoolz.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-dash.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-dash_bootstrap_components.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-dash_core_components.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-dash_html_components.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-dash_renderer.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-dash_table.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-dash_uploader.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-dask.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-dateparser.utils.strptime.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-dclab.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-distorm3.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-dns.rdata.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-docutils.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-docx.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-docx2pdf.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-dynaconf.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-eel.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-enchant.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-enzyme.parsers.ebml.core.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-eth_abi.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-eth_account.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-eth_hash.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-eth_keyfile.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-eth_utils.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-fabric.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-faker.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-ffpyplayer.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-flask_compress.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-flask_restx.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-flex.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-flirpy.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-fmpy.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-folium.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gadfly.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gcloud.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gitlab.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gmplot.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gooey.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-google.api.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-google.api_core.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-google.cloud.bigquery.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-google.cloud.kms_v1.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-google.cloud.pubsub_v1.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-google.cloud.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-google.cloud.speech.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-google.cloud.storage.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-google.cloud.translate.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-googleapiclient.model.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gst._gst.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-gtk.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-h5py.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-HtmlTestRunner.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-httplib2.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-humanize.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-ijson.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-imageio.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-imageio_ffmpeg.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-iminuit.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-IPython.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-jaraco.text.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-jedi.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-jinja2.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-jinxed.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-jira.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-jsonpath_rw_ext.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-jsonrpcserver.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-jsonschema.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-jupyterlab.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-kaleido.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-kinterbasdb.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-langcodes.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-langdetect.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-lensfunpy.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-libaudioverse.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-lightgbm.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-llvmlite.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-logilab.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-lxml.etree.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-lxml.isoschematron.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-lxml.objectify.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-lxml.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-lz4.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-magic.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-mako.codegen.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-mariadb.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-markdown.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-metpy.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-migrate.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-mimesis.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-mnemonic.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-mpl_toolkits.basemap.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-msoffcrypto.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-nacl.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-names.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-nanite.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-nbconvert.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-nbdime.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-nbformat.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-ncclient.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-netCDF4.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-nltk.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-nnpy.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-notebook.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-numba.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-office365.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-OpenGL.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-OpenGL_accelerate.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-openpyxl.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-orjson.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-osgeo.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-panel.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-parsedatetime.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-parso.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-passlib.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-paste.exceptions.reporter.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-patsy.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pdfminer.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pendulum.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-phonenumbers.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pingouin.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pint.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pinyin.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-platformdirs.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-plotly.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-prettytable.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-psychopy.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-psycopg2.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-publicsuffix2.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pubsub.core.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-puremagic.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-py.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyarrow.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pycountry.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pycparser.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pydantic.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pydivert.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyexcel-io.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyexcel-ods.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyexcel-ods3.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyexcel-odsr.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyexcel-xls.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyexcel-xlsx.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyexcel-xlsxw.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyexcel.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyexcelerate.Writer.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyexcel_io.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyexcel_ods.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyexcel_ods3.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyexcel_odsr.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyexcel_xls.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyexcel_xlsx.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyexcel_xlsxw.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pygraphviz.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pylint.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pymediainfo.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pymssql.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pynput.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyodbc.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyopencl.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyphen.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyppeteer.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyproj.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pypsexec.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pypylon.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyqtgraph.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pysnmp.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pystray.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pytest.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pythoncom.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyttsx.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyttsx3.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyviz_comms.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pyvjoy.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pywintypes.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-pywt.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-qtmodern.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-radicale.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-raven.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-rawpy.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-rdflib.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-redmine.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-regex.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-reportlab.lib.utils.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-reportlab.pdfbase._fontdata.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-resampy.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-rpy2.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-rtree.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-sacremoses.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-selenium.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-sentry_sdk.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-shapely.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-shotgun_api3.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-skimage.feature.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-skimage.filters.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-skimage.graph.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-skimage.io.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-skimage.transform.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-sklearn.cluster.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-sklearn.linear_model.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-sklearn.metrics.cluster.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-sklearn.neighbors.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-sklearn.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-sklearn.tree.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-sklearn.utils.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-sounddevice.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-soundfile.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-sound_lib.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-spacy.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-speech_recognition.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-spnego.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-srsly.msgpack._packer.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-statsmodels.tsa.statespace.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-storm.database.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-sunpy.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-swagger_spec_validator.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-tableauhyperapi.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-tables.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-tcod.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-tensorflow.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-textdistance.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-text_unidecode.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-thinc.backends.numpy_ops.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-thinc.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-timezonefinder.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-tinycss2.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-torch.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-torchvision.ops.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-trimesh.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-ttkthemes.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-ttkwidgets.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-tzdata.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-u1db.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-umap.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-unidecode.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-uniseg.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-usb.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-uvicorn.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-uvloop.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-vtkpython.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-wavefile.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-weasyprint.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-web3.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-webassets.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-webrtcvad.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-websockets.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-webview.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-win32com.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-workflow.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-wx.lib.activex.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-wx.lib.pubsub.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-wx.xrc.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-Xlib.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-xml.dom.html.HTMLDocument.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-xml.sax.saxexts.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-xmldiff.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-xsge_gui.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-zeep.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-zmq.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-zoneinfo.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-_mssql.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ hook-_mysql.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ rthooks.dat
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ tests
 ┃ ┃ ┃ ┃ ┃ ┣ data
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ netcore5_runtime_config.json
 ┃ ┃ ┃ ┃ ┃ ┣ scripts
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_lib_boto.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_lib_enchant.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_lib_pycparser.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_lib_tensorflow_layer.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ pyi_lib_tensorflow_mnist.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_lib_boto.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_lib_enchant.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_lib_pycparser.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ pyi_lib_tensorflow_layer.py
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ pyi_lib_tensorflow_mnist.py
 ┃ ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ conftest.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ test_libraries.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┃ ┣ conftest.py
 ┃ ┃ ┃ ┃ ┃ ┣ test_libraries.py
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┃ ┗ __init__.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┗ __init__.py
 ┃ ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┃ ┣ bottle.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┣ pefile.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┣ peutils.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┣ png.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┣ six.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┣ whichcraft.cpython-39.pyc
 ┃ ┃ ┃ ┃ ┗ _virtualenv.cpython-39.pyc
 ┃ ┃ ┃ ┣ bottle.py
 ┃ ┃ ┃ ┣ distutils-precedence.pth
 ┃ ┃ ┃ ┣ pefile.py
 ┃ ┃ ┃ ┣ peutils.py
 ┃ ┃ ┃ ┣ pip-21.1.2.virtualenv
 ┃ ┃ ┃ ┣ png.py
 ┃ ┃ ┃ ┣ setuptools-57.0.0.virtualenv
 ┃ ┃ ┃ ┣ six.py
 ┃ ┃ ┃ ┣ wheel-0.36.2.virtualenv
 ┃ ┃ ┃ ┣ whichcraft.py
 ┃ ┃ ┃ ┣ zope.event-4.5.0-py3.6-nspkg.pth
 ┃ ┃ ┃ ┣ zope.interface-5.4.0-py3.9-nspkg.pth
 ┃ ┃ ┃ ┣ _cffi_backend.cp39-win_amd64.pyd
 ┃ ┃ ┃ ┣ _virtualenv.pth
 ┃ ┃ ┃ ┗ _virtualenv.py
 ┃ ┣ Scripts
 ┃ ┃ ┣ __pycache__
 ┃ ┃ ┃ ┣ bottle.cpython-39.pyc
 ┃ ┃ ┃ ┗ read_zbar.cpython-39.pyc
 ┃ ┃ ┣ activate
 ┃ ┃ ┣ activate.bat
 ┃ ┃ ┣ activate.fish
 ┃ ┃ ┣ activate.ps1
 ┃ ┃ ┣ activate.xsh
 ┃ ┃ ┣ activate_this.py
 ┃ ┃ ┣ auto-py-to-exe.exe
 ┃ ┃ ┣ autopytoexe.exe
 ┃ ┃ ┣ bottle.py
 ┃ ┃ ┣ deactivate.bat
 ┃ ┃ ┣ f2py.exe
 ┃ ┃ ┣ futurize.exe
 ┃ ┃ ┣ pasteurize.exe
 ┃ ┃ ┣ pip-3.9.exe
 ┃ ┃ ┣ pip.exe
 ┃ ┃ ┣ pip3.9.exe
 ┃ ┃ ┣ pip3.exe
 ┃ ┃ ┣ prichunkpng
 ┃ ┃ ┣ priditherpng
 ┃ ┃ ┣ priforgepng
 ┃ ┃ ┣ prigreypng
 ┃ ┃ ┣ pripalpng
 ┃ ┃ ┣ pripamtopng
 ┃ ┃ ┣ pripnglsch
 ┃ ┃ ┣ pripngtopam
 ┃ ┃ ┣ priweavepng
 ┃ ┃ ┣ pydoc.bat
 ┃ ┃ ┣ pyi-archive_viewer.exe
 ┃ ┃ ┣ pyi-bindepend.exe
 ┃ ┃ ┣ pyi-grab_version.exe
 ┃ ┃ ┣ pyi-makespec.exe
 ┃ ┃ ┣ pyi-set_version.exe
 ┃ ┃ ┣ pyinstaller.exe
 ┃ ┃ ┣ python.exe
 ┃ ┃ ┣ pythonw.exe
 ┃ ┃ ┣ range-detector
 ┃ ┃ ┣ read_zbar.exe
 ┃ ┃ ┣ read_zbar.py
 ┃ ┃ ┣ wheel-3.9.exe
 ┃ ┃ ┣ wheel.exe
 ┃ ┃ ┣ wheel3.9.exe
 ┃ ┃ ┗ wheel3.exe
 ┃ ┣ .gitignore
 ┃ ┗ pyvenv.cfg
 ┣ __pycache__
 ┃ ┣ main.cpython-39.pyc
 ┃ ┗ scan_webcam.cpython-39.pyc
 ┣ build.spec
 ┣ filename.spec
 ┣ main.py
 ┣ main.spec
 ┣ requirements.txt
 ┗ scan_webcam.py
```
