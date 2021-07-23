## Design branch ##

This is the home of our design team.
Here every change made will result in a nicer level/sound/economy design before going to the `design` branch for our programming team to test their silly code on those beauties.   

Please read [design-contributing](https://github.com/RPGeeks/curly-burly/blob/main/DESIGN_CONTRIBUTING.md) before creating a Pull Request.  

## Development setup ##

It is required that you have [git LFS](https://git-lfs.github.com) installed.

```bash
git clone https://github.com/RPGeeks/curly-burly.git
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
A: "Add object_x, modify prefab_y"_ 

_!note2: Your commits should be also short, make your reviewers life easy and he might do the same._