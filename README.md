For non commercial use

These prorams are for for anyone that lives in the command line interface (ie cmd.exe) and
changes folders at a whim. while this shows only one slot being saved, it will be enhanced to
save many slots with additional enhancments.

The core of this Project are two files, SavePath.cmd and Return.cmd,

both will be simplified to sp.cmd and rt.cmd for efficiency sake.

| File | Short Form | Contents |
| --- | --- | --- |
| SavePath.cmd | sp.cmd | `set "ReturnSlot=%cd%"` |
| Return.cmd | rt.cmd | `cd /D %ReturnSlot%` |

Save the two files in a folder that is in the %PATH% variable

To run the quick demo, do the following from a command prompt.

in the current directory, type in sp.cmd and press enter.

this saves the current directory as a slot.

navigate to another folder.

in the folder, type in rt.cmd and press enter.

the command will return you to the folder where you saved the path (slot)

| Future parameters | explanation |
| --- | --- |
| Numbers | numbers slots 1-9 |
| Letters | lettered slots A-G |
| Global |  makes the slot global|
| Help | shows the help file |
| Name | names a folder, very powerful |
| Purge | purges slots |
| Dekete | deletes slots |
| Restore | restores slots from file |
| Save | saves slots to file |
| Show | shows the used slots |
| Ver | shows the slot version |
| Misc | additional error control |
