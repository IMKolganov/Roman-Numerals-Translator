/*
Create an implementation of a function that converts an integer input into a string, 
containing a valid roman number.
List of all possible roman literals: 
I             1
V             5
X             10
L             50
C             100
D             500
M             1000

I may go before V and X (10)
X may go before L (50) and C
C may go before D (500) and M

Table with all possible digits in roman system:
            1 2  3   4  5 6  7   8    9
1-9         I II III IV V VI VII VIII IX
10-90       X XX XXX XL L LX LXX LXXX XC
100-900     C CC CCC CD D DC DCC DCCC CM
1000-3000   M MM MMM

Examples:
11 => X I
123 => C XX III
498 => CD XC VIII
1987 => M CM LXXX VII
2023 => MM XX III

1645 => M DC XL V
504 => 

*/

