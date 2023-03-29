# C-Unity-Gravity-Script
got frustrated looking for a good gravitational script so I made my own

Works and tested on Unity 2021.3.131f

Gravscript_v1: Functions perfectly but produces errors in console.
Gravscript_v2: Should function but currently untested.

How to use:
Create a Tag named "Planet"
Apply tag to any bodies that should emit gravity
Make sure the emission objects contain a RigidBody to account for mass (if you don't want them to move, make sure Is Kinematic is checked)
Add the script to the GameObject that should be effected by gravity
Make sure the effected objects contain a RigidBody as well
Set param rb to the effected object's rigidbody
Param objrb can be left blank
Set the gravitational constant to preference
Then you can run the game


