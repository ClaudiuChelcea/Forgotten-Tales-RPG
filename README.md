# Forgotten Tales
# Multiplayer co-op RPG

A multiplayer co-op RPG game developed in a team of 22 persons during a game development summer school.

Personal contributions:
- Management: meetings, progress presentations, setting objectives, team management, announcements, documents management
- Sounds: added sounds to different parts of the game, eg: character selection music, background sound, buttons sounds and sound scripts created in C# to allow continuity between music and other features
- Game map: developed a big part of the game map, from creating the concept and areas to implementing them in Unity
- Game design document: collaborated with the design team in creating the GDD
- Presentations to the teachers and to all the participants of the summer school of our game
- Testing & bug issuing

Presentation: https://opreaolivia73.wixsite.com/rpgeeks3
![Screenshot (271)](https://user-images.githubusercontent.com/74200190/129561671-0dca688a-61b7-46e6-91f2-9e5ba6a8d0ca.png)
![Screenshot (297)](https://user-images.githubusercontent.com/74200190/129561682-5e2832fa-c338-41bd-bc5a-c4aa933bcfef.png)
![Screenshot (298)](https://user-images.githubusercontent.com/74200190/129561691-3772f079-3859-4db0-bc1a-5d01ef2fd55f.png)


## Development setup ##

It is required that you have [git LFS](https://git-lfs.github.com) installed.

```bash
git clone https://github.com/ClaudiuChelcea/Forgotten-Tales-RPG
cd curly-burly
git submodule update --init --recursive
```
Create your own branch, chose a name descriptive for your work.

```bash
git checkout -b <insert_branch_name>
``` 

When you reach a stable behaviour commit your changes and open a Pull Request.

```bash
git add *
git status # double check everything is fine
git commit -a -m "<your_message_here>"
git push origin <insert_branch_name>
```
_!note: Your message should be short but self-explenatory.  
You might thing of that as the answer to:
Q: "What will this commit do?"  
A: "Add feature_x and solve bug_y"_ 

_!note2: Your commits should be also short, make your reviewers life easy and he might do the same._

# Playing / build scene: Menu
