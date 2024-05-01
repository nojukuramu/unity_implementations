# MacroInterpreter

<p align="center">
This is the founding base for MacroInterpreter.

### How to use sample usage.
I. Scene setup:
   1. Import the scripts into the project.
   2. Attach both files in an object.
   3. Make a Legacy Text game object.
   3. Reference the Legacy Text game object to the MacroInterpreter.

II. Text file setup:
   1. In your project window, navigate to Asset/StreamingAsset. If it doesn't exist, create a folder.
   2. create a text file named macro.txt

### How It Works
1. TextFileReader reads the file and returns only the Line specified.
2. MacroInterpreter uses the TextFileReader function to get a line.
3. MacroInterpreter will make a sense whatever is being read depending on the logic you do.
