# SaveGame

Topic: Game Save

Platform: Unity 3D

Language: C#

Intro: Saving the progress is essential for almost every game. When I was learning Unity 3D, I tried to create bigger games rather than one-time mini-games. After browsing the YouTube and the forum of Unity, I realized there are serval ways to save game progress. Each of them has different cons and pons. One of these approaches is very beginner-friendly because it is fairly simple and reliable.

Method: Using the "PlayerPrefs".

Detailed Steps:
- Create two buttons and name them "Save" and "Load".
- Create a C# file called "save".
- Write a public function "save" that is using the code "PlayerPrefs.SetFloat("MyFloat", myFloat)" ('SetFloat' can be replaced as 'Set + whateverTypeofVar'. The 'myFloat' is the variable you like to store.
- Write a public function "load" that is using the code "myFloat = PlayerPrefs.GetFloat("MyFloat");" Similar to the step above, 'myFloat' is just the variable you want to load. And 'GetFloat' can be changed depends on what type of the variable is. Because C# is a relatively rigorous language.
- Modify the variable in the game and then save it.
- Quit the game and reopen to load.
- See if the data is restored.
