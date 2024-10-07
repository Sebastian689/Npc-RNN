# Npc-RNN
An RNN for NPCs in a Unity project written from scratch. Might be upgraded to a GRU or LSTM with time.

# Getting started
## Step 1: Build DLL
Open the DLL solution file with Visual Studio and build it. (Check build settings to see if they are correctly building to x64 architecture).
The console shows the location of the build.

## Step 2: Create Unity Plugin
Create a Plugin folder in the Asset folder and copy the dll into the folder.  

In the Unity script that uses the DLL, add "using System.Runtime.InteropServices;".

Functions can now be imported with DLLImport attribute.  
Example: 
[DllImport("RNN")]  
public static extern int test_function();