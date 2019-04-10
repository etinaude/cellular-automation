# this is a version of the cell formula algorithm used written in a version sudo code
## TL refers to top left (cell above and to the left of the curret one)
## TM refers to top middle
## TR refers to top right
## reference is a function which uses the input to look up the correct value in a refernce table
```python
IF(TL="W")
	IF(TM="W" AND TR="W")
		reference(000)
	Else IF(TM="W" AND TR="B")
			reference(001)
		Else IF(TM="B" AND TR="W")
				reference(010)
		      Else IF(TM="B" AND TR="B")
				reference(011)
			  Else
				"Error 0"
	IF(AND(TM="W",TR="W")
		reference(100)
	Else IF(AND(TM="W",TR="B")
			reference(101)
		Else IF(AND(TM="B",TR="W")
				reference(110)
		     Else IF(AND(TM="B",TR="B")
				reference(111)
			   Else
				"Error 1"
'''
