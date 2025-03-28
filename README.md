ANA JULIA E GUSTAVO


2ds@PCLAB3-02 MINGW64 ~/Desktop/Projeto1 (master)
$ git remote add https://github.com/Anajuxgit23/projeto1.git
usage: git remote add [<options>] <name> <url>

    -f, --[no-]fetch      fetch the remote branches
    --[no-]tags           import all tags and associated objects when fetching
                          or do not fetch any tag at all (--no-tags)
    -t, --[no-]track <branch>
                          branch(es) to track
    -m, --[no-]master <branch>
                          master branch
    --[no-]mirror[=(push|fetch)]
                          set up remote as a mirror to push to or fetch from


2ds@PCLAB3-02 MINGW64 ~/Desktop/Projeto1 (master)
$ git push
fatal: No configured push destination.
Either specify the URL from the command-line or configure a remote repository using

    git remote add <name> <url>

and then push using the remote name

    git push <name>


2ds@PCLAB3-02 MINGW64 ~/Desktop/Projeto1 (master)
$ git remote add origin https://github.com/Anajuxgit23/projeto1.git

2ds@PCLAB3-02 MINGW64 ~/Desktop/Projeto1 (master)
$ git add .

2ds@PCLAB3-02 MINGW64 ~/Desktop/Projeto1 (master)
$ branch
bash: branch: command not found

2ds@PCLAB3-02 MINGW64 ~/Desktop/Projeto1 (master)
$ git branch

2ds@PCLAB3-02 MINGW64 ~/Desktop/Projeto1 (master)
$ git branch main
fatal: not a valid object name: 'master'

2ds@PCLAB3-02 MINGW64 ~/Desktop/Projeto1 (master)
$ git checkout -b main
Switched to a new branch 'main'

2ds@PCLAB3-02 MINGW64 ~/Desktop/Projeto1 (main)
$ git add .

2ds@PCLAB3-02 MINGW64 ~/Desktop/Projeto1 (main)
$ git commit -m "commitando"
[main (root-commit) 6718a69] commitando
 Committer: 2DS <2ds@bglab.local>
Your name and email address were configured automatically based
on your username and hostname. Please check that they are accurate.
You can suppress this message by setting them explicitly. Run the
following command and follow the instructions in your editor to edit
your configuration file:

    git config --global --edit

After doing this, you may fix the identity used for this commit with:

    git commit --amend --reset-author

 16 files changed, 1372 insertions(+)
 create mode 100644 .gitignore
 create mode 100644 App.config
 create mode 100644 Form1.Designer.cs
 create mode 100644 Form1.cs
 create mode 100644 Form1.resx
 create mode 100644 Form2.Designer.cs
 create mode 100644 Form2.cs
 create mode 100644 Form2.resx
 create mode 100644 Program.cs
 create mode 100644 Projeto1.csproj
 create mode 100644 Projeto1.sln
 create mode 100644 Properties/AssemblyInfo.cs
 create mode 100644 Properties/Resources.Designer.cs
 create mode 100644 Properties/Resources.resx
 create mode 100644 Properties/Settings.Designer.cs
 create mode 100644 Properties/Settings.settings

2ds@PCLAB3-02 MINGW64 ~/Desktop/Projeto1 (main)
$ git push
fatal: The current branch main has no upstream branch.
To push the current branch and set the remote as upstream, use

    git push --set-upstream origin main

To have this happen automatically for branches without a tracking
upstream, see 'push.autoSetupRemote' in 'git help config'.


2ds@PCLAB3-02 MINGW64 ~/Desktop/Projeto1 (main)
$ git push origin main
info: please complete authentication in your browser...
To https://github.com/Anajuxgit23/projeto1.git
 ! [rejected]        main -> main (fetch first)
error: failed to push some refs to 'https://github.com/Anajuxgit23/projeto1.git'
hint: Updates were rejected because the remote contains work that you do not
hint: have locally. This is usually caused by another repository pushing to
hint: the same ref. If you want to integrate the remote changes, use
hint: 'git pull' before pushing again.
hint: See the 'Note about fast-forwards' in 'git push --help' for details.

2ds@PCLAB3-02 MINGW64 ~/Desktop/Projeto1 (main)
$ git push origin main
To https://github.com/Anajuxgit23/projeto1.git
 ! [rejected]        main -> main (fetch first)
error: failed to push some refs to 'https://github.com/Anajuxgit23/projeto1.git'
hint: Updates were rejected because the remote contains work that you do not
hint: have locally. This is usually caused by another repository pushing to
hint: the same ref. If you want to integrate the remote changes, use
hint: 'git pull' before pushing again.
hint: See the 'Note about fast-forwards' in 'git push --help' for details.

2ds@PCLAB3-02 MINGW64 ~/Desktop/Projeto1 (main)
$ git push origin main
To https://github.com/Anajuxgit23/projeto1.git
 ! [rejected]        main -> main (fetch first)
error: failed to push some refs to 'https://github.com/Anajuxgit23/projeto1.git'
hint: Updates were rejected because the remote contains work that you do not
hint: have locally. This is usually caused by another repository pushing to
hint: the same ref. If you want to integrate the remote changes, use
hint: 'git pull' before pushing again.
hint: See the 'Note about fast-forwards' in 'git push --help' for details.

2ds@PCLAB3-02 MINGW64 ~/Desktop/Projeto1 (main)
$ git push
fatal: The current branch main has no upstream branch.
To push the current branch and set the remote as upstream, use

    git push --set-upstream origin main

To have this happen automatically for branches without a tracking
upstream, see 'push.autoSetupRemote' in 'git help config'.


2ds@PCLAB3-02 MINGW64 ~/Desktop/Projeto1 (main)
$ git push orin main
fatal: 'orin' does not appear to be a git repository
fatal: Could not read from remote repository.

Please make sure you have the correct access rights
and the repository exists.

2ds@PCLAB3-02 MINGW64 ~/Desktop/Projeto1 (main)
$ git push origin main
To https://github.com/Anajuxgit23/projeto1.git
 ! [rejected]        main -> main (fetch first)
error: failed to push some refs to 'https://github.com/Anajuxgit23/projeto1.git'
hint: Updates were rejected because the remote contains work that you do not
hint: have locally. This is usually caused by another repository pushing to
hint: the same ref. If you want to integrate the remote changes, use
hint: 'git pull' before pushing again.
hint: See the 'Note about fast-forwards' in 'git push --help' for details.

2ds@PCLAB3-02 MINGW64 ~/Desktop/Projeto1 (main)
$ git push origin main
To https://github.com/Anajuxgit23/projeto1.git
 ! [rejected]        main -> main (fetch first)
error: failed to push some refs to 'https://github.com/Anajuxgit23/projeto1.git'
hint: Updates were rejected because the remote contains work that you do not
hint: have locally. This is usually caused by another repository pushing to
hint: the same ref. If you want to integrate the remote changes, use
hint: 'git pull' before pushing again.
hint: See the 'Note about fast-forwards' in 'git push --help' for details.

2ds@PCLAB3-02 MINGW64 ~/Desktop/Projeto1 (main)
$ git push -u origin main
To https://github.com/Anajuxgit23/projeto1.git
 ! [rejected]        main -> main (fetch first)
error: failed to push some refs to 'https://github.com/Anajuxgit23/projeto1.git'
hint: Updates were rejected because the remote contains work that you do not
hint: have locally. This is usually caused by another repository pushing to
hint: the same ref. If you want to integrate the remote changes, use
hint: 'git pull' before pushing again.
hint: See the 'Note about fast-forwards' in 'git push --help' for details.

2ds@PCLAB3-02 MINGW64 ~/Desktop/Projeto1 (main)
$ git push -u origin main
To https://github.com/Anajuxgit23/projeto1.git
 ! [rejected]        main -> main (fetch first)
error: failed to push some refs to 'https://github.com/Anajuxgit23/projeto1.git'
hint: Updates were rejected because the remote contains work that you do not
hint: have locally. This is usually caused by another repository pushing to
hint: the same ref. If you want to integrate the remote changes, use
hint: 'git pull' before pushing again.
hint: See the 'Note about fast-forwards' in 'git push --help' for details.

2ds@PCLAB3-02 MINGW64 ~/Desktop/Projeto1 (main)





















From https://github.com/Anajuxgit23/projeto1
 * branch            main       -> FETCH_HEAD
Merge made by the 'ort' strategy.

2ds@PCLAB3-02 MINGW64 ~/Desktop/Projeto1 (main)
$ git push -u origin main
Enumerating objects: 19, done.
Counting objects: 100% (19/19), done.
Delta compression using up to 12 threads
Compressing objects: 100% (18/18), done.
Writing objects: 100% (18/18), 9.24 KiB | 3.08 MiB/s, done.
Total 18 (delta 4), reused 0 (delta 0), pack-reused 0 (from 0)
remote: Resolving deltas: 100% (4/4), done.
To https://github.com/Anajuxgit23/projeto1.git
   a9b4dfb..e895d09  main -> main
branch 'main' set up to track 'origin/main'.

2ds@PCLAB3-02 MINGW64 ~/Desktop/Projeto1 (main)
$
