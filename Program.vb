Imports System
Imports System.IO

Module Program
    Sub Main(args As String())
        Dim wsb =
            <Configuration>
                <VGpu>Disable</VGpu>
                <Networking>Disable</Networking>
                <MappedFolders>
                    <MappedFolder>
                        <HostFolder><%= Path.Combine(Directory.GetCurrentDirectory(), "src") %></HostFolder>
                        <ReadOnly>true</ReadOnly>
                    </MappedFolder>
                </MappedFolders>
                <LogonCommand>
                    <Command>C:\Users\WDAGUtilityAccount\Desktop\src\set-desktop-background.bat</Command>
                </LogonCommand>
            </Configuration>
        File.WriteAllText("set-desktop-background.wsb", wsb.ToString())
    End Sub
End Module
