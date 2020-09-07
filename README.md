# Cellular Automation
## excel cellular automation 
 
I created this a few years ago and found it sitting around on my google drive and thought someone might find it interesting, So I thought I'd update it
 
[cellular automation](https://en.wikipedia.org/wiki/Cellular_automaton) is a system of creating patterns based on cell values around a particular cell. A well known example of cellular automation is [conway's game of life](https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life), (I have a version of this in a different repo)
 
This is a contiunously ongoing project.
 
This is an example of [**elementary** cellular automaton](https://en.wikipedia.org/wiki/Elementary_cellular_automaton), the first row between the purple cells is the user input row, the rows beneath that change their colour based on the "rule" and the user input.
 
There is a key on under the size input. For each cell look at the 3 cells above it then follow the key then that cell will change to that value
 
**There is both both a macros edition and a cell formulae edition for excel**
 
The macro edition uses 1s and 0s BUT the formulae edition uses "B"s and "W"s since excel occationally switched 0 to "0" and vise versa same for the ones.


# Patterns

These two patterns are made from the same rule (111) but with a different input into the first row. this causes different patterns to form but since they are bsed on the same rule you cna see similar patterns on the left and right sides, this is caused by (0/b) being default values
![Demo picture](https://github.com/etinaude/cellular-automation/blob/master/pictures/demo.png)

![Demo picture](https://github.com/etinaude/cellular-automation/blob/master/pictures/demo2.png)

## Each row

The each row file, is an interesting set of rules, there are 255 rows in the files, row 0 has rule 0, row 1 has rule 1 etc, since it starts at rule 0 the input wont change the outcome
