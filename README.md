# cellular-automation
## excel cellular automation 

I created this a few years ago and found it sitting around on my google drive and thought somone might find it intersting, So I thought Id update it
[cellular automation](https://en.wikipedia.org/wiki/Cellular_automaton) is a system of creating patterns based on a byte binary input as a rule and a sinle bit to be processed at a time
that bits output creates part of the input for the next series.

a well knowen example of cellular automation is [conways game of life](https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life)

I will hopefully work on updating this in the future

currently the first row is the input to be processed and the cell C1 (RULE:) shows the rule which the input is proccessed by this can be changed to any integer value from 0 to 255 (ones inbetween are far more intersting)

there is a key on the left if the cells above (top left, top, top right) the current cell are what is shown in the key then the cell will change to the shown output, no cell it counted as a light grey/white cell (w). this patern flows down to the 50th row.

this version is currently unstable and not properly tested for bugs and is fairly slow, more features and improvements are on their way!

**this version has been updated to use macros rather than cell formulae**
