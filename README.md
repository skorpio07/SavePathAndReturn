![Alt](https://repobeats.axiom.co/api/embed/64efede69a455df79704d6788a7fc5a23b7140d9.svg "Repobeats analytics image")
[![My Skills](https://skillicons.dev/icons?i=autocad,cs,codepen,devto,discord,dotnet,github,gmail,html,ai,instagram,linkedin,lua,md,robloxstudio,stackoverflow,twitter,ubuntu,visualstudio,vscode,windows,wordpress)](https://skillicons.dev)

For non commercial use

For commercial use, apps have been developed and are in testing. Stay tuned.

These programs are for anyone that lives in the command line interface (ie cmd.exe) and
changes folders frequently. while this shows only one slot being saved, it will be enhanced to
save many slots with additional enhancments.

The core of this Project are two files, SavePath and Return,

Both will be simplified to sp.cmd and rt.cmd for efficiency sake.

| File | Short Form | Contents |
| --- | --- | --- |
| SavePath | sp.cmd | `set "ReturnSlot=%cd%"` |
| Return | rt.cmd | `cd /D %ReturnSlot%` |

Copy the Contents into each file, note that there is only one line in each file.

Save the two files in a folder that is in the %PATH% variable.

To run the quick demo, do the following from a command prompt.

In the current directory, type in `sp.cmd` and press enter.

This saves the current directory as a return slot.

Navigate to another folder.

In that folder, type in `rt.cmd` and press enter.

The command will return you to the folder where you saved the path (slot).

Will be updating the apps every week or two till complete.

| Future parameters | Explanation |
| --- | --- |
| Numbers | numbered slots 1-9 |
| Letters | lettered slots A-G |
| Global |  makes the slot global|
| Help | shows the help file |
| Name | names a folder, very powerful |
| Purge | purges slots |
| Delete | deletes slots |
| Restore | restores slots from file |
| Save | saves slots to file |
| Show | shows the used slots |
| Ver | shows the savepath version |
| Misc | error control |
| Misc | save to program files x86 |

[Click to open the Outline](Outline.md)
