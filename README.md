# SampleConsole
Simple console app for demoing Git

# Walkthrough

## Clone this repository first!
Replace "MySampleConsole" with whatever you want to call the repository

`git clone https://github.com/ingledewjf/SampleConsole MySampleConsole`

## Create a new branch for your changes
Replace "mybranch" with whatever your name

`git checkout -b mybranch`

## Make your changes
Open up the solution in VS and modify files however you'd like

## Check in!
First, check the status

`git status`

Then, stage any untracked files with

`git add .`

(You may also choose to add individual files with git add path/to/file)

Commit your changes locally with

`git commit -m "My message here"`

And finally, push to the remote repository

`git push origin mybranch`

Once a few people have pushed their changes, you can try fetching and merging changes in from other branches

`git fetch origin anotherbranch`

`git merge anotherbranch`

`git push origin mybranch`

You may also submit a pull request to get your changes merged into master.
