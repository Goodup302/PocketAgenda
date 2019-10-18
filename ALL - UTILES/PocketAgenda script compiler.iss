; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "PocketAgenda"
#define MyAppVersion "1.3"
#define MyAppPublisher "GoodUp302, Inc."
#define MyAppURL "http://www.goodup302.fr/"
#define MyAppExeName "PocketAgenda.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{F0BD5000-4606-4562-82DE-36C91F2A7C32}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\Pocketagenda
DisableDirPage=yes
DisableProgramGroupPage=yes
OutputDir=C:\Users\Principal\Desktop
OutputBaseFilename=PocketAgenda_Setup_v1.3
SetupIconFile=C:\Users\Principal\Documents\Visual Studio 2015\Projects\PocketAgenda\ALL - UTILES\Logo\1466301260_Install1.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "french"; MessagesFile: "compiler:Languages\French.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\Principal\Documents\Visual Studio 2015\Projects\PocketAgenda\pocketagenda\Design\bin\Debug\PocketAgenda.exe"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{commonprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent
