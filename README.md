# cellular-automation
## excel cellular automation 
 
I created this a few years ago and found it sitting around on my google drive and thought someone might find it interesting, So I thought I'd update it
 
[cellular automation](https://en.wikipedia.org/wiki/Cellular_automaton) is a system of creating patterns based on cell values around next to a particular cell
 
a well known example of cellular automation is [conway's game of life](https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life)
 
I will hopefully keep working on updating this in the future
 
this is an example of [elementary cellular automaton](https://en.wikipedia.org/wiki/Elementary_cellular_automaton), the first row between the purple cells is the user input row, the rows beneath that change their colour based on the "rule" and the user input.
 
there is a key on under the size input. For each cell look at the 3 cells above it then follow the key then that cell will change to that value
 
**this version has both a macros edition and a cell formulae edition**
 
the macro edition uses 1s and 0s BUT the formulae edition uses "B"s and "W"s since excel unpredictably switched 0 to "0" and vise versa same for the ones.


# each row

this is a document that comes in xlsx and ods formats it is an extention of the other celular automation, the way each row works, it each row has a different elementary rule assosaited with it, starting at rule 000 and ending at rule 255 it contains just under 80, 000 cells to update so it can take some time. since the first rule is 000 the input row doesn't change the output state.
