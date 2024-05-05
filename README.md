![Alt](https://repobeats.axiom.co/api/embed/64efede69a455df79704d6788a7fc5a23b7140d9.svg "Repobeats analytics image")
[![My Skills](https://skillicons.dev/icons?i=html,css,wasm)](https://skillicons.dev)
https://github.com/tandpfun/skill-icons?tab=readme-ov-file#icons-list

For non commercial use

For commercial use, apps have been developed and are in testing. Stay tuned.

These prorams are for anyone that lives in the command line interface (ie cmd.exe) and
changes folders at a whim. while this shows only one slot being saved, it will be enhanced to
save many slots with additional enhancments.

The core of this Project are two files, SavePath.cmd and Return.cmd,

Both will be simplified to sp.cmd and rt.cmd for efficiency sake.

| File | Short Form | Contents |
| --- | --- | --- |
| SavePath.cmd | sp.cmd | `set "ReturnSlot=%cd%"` |
| Return.cmd | rt.cmd | `cd /D %ReturnSlot%` |

Copy the Contents into each file, note that there is only one line in the batch files.

Save the two files in a folder that is in the %PATH% variable.

To run the quick demo, do the following from a command prompt.

In the current directory, type in `sp.cmd` and press enter.

This saves the current directory as a slot.

Navigate to another folder.

In the folder, type in `rt.cmd` and press enter.

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

Link to ./Return.cmd
