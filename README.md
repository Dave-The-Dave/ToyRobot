# ToyRobot
 A basic console application to simulate a toy robot moving on a table.
 The app is designed to use OOP with examples of interfaces, inheritance, and unit tests. The following commands can be used:

PLACE X,Y,F

MOVE

LEFT

RIGHT

REPORT

# Requirements 

The application is a simulation of a toy robot moving on a square tabletop, of dimensions 5 units x 5 units.

There are no other obstructions on the table surface.

The robot is free to roam around the surface of the table, but must be prevented from falling to destruction. Any movement that would result in the robot falling from the table must be prevented, however further valid movement commands must still be allowed.

# Constraints 

The toy robot must not fall off the table during movement. This also includes the initial placement of the toy robot. Any move that would cause the robot to fall must be ignored.

# Example Input and Output 

a)

PLACE 0,0,NORTH

MOVE 

REPORT


Output: 0,1,NORTH

b)

PLACE 0,0,NORTH

LEFT 

REPORT

Output: 0,0,WEST

c)

PLACE 1,2,EAST 

MOVE 

MOVE 

LEFT 

MOVE 

REPORT


Output: 3,3,NORTH
