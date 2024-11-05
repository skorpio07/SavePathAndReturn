# Tutorial for SavePath #

1. Beginning

    The concept is to save a folder (current directory) to an environment variable
    and then switch to that folder whenever it is needed. The command to save a folder
    is called `SavePath` (whether .cmd or .exe) and the command to switch back to that
    folder is called `Return`.
2. First Step

    Decide where you will be placing the files. In the finished project, the folder
    for the executables will be `C:\Program Files (x86)\SavePathAndReturn`. You can of
    course, place them anywhere in the %PATH% variable for convienent use. If you decide
    to put them in Program Files x86 folder, then you will need administrator rights to 
    do so. This is only for saving the files. To update the %PATH% variable, type in the
    following two commands:

    `Set "Path=%PATH%;C:\Program Files (x86)\SavePathAndReturn"`

    `Setx Path "%PATH%;C:\Program Files (x86)\SavePathAndReturn"`
4. Running the Demo

    Switch to a folder in the path if necessary. Then type in the following: 
    `Copy Con SavePath.cmd` and press Enter. 
    This will bring you into the      internal editor. Type the following 
    command on the current line:
    `Set "ReturnSlot=%cd%"` and press Enter.
    Then press the F6 key (or you can press Control-Z) to save and close the editor.
    Now type in the following: 
    `Copy Con Return.cmd` and press Enter.
    Then type in the following on the current line:
    `cd /D %ReturnSlot%` and press Enter to save and close the editor.

6. Test both files
    In a folder that you want to return to, type in 
    `SavePath` and press Enter.
    Now navigate away from that folder. When you want to switch back to the folder
    that you just saved, type in 
    `Return` and press Enter.
    The program will take you back to the folder that you just saved.
7. Next Steps

    This simplified program demonstrates how to navigate the directory tree quickly. 
