# C-Unity-Gravity-Script
got frustrated looking for a good gravitational script so I made my own

Works and tested on Unity 2021.3.131f

Gravscript_v1: Functions perfectly but produces errors in console when script is applied to an object taged as "Planet" but everything still functions properly 
Gravscript_v2: Should function but currently untested.
Gravscript_v0: Works with only one planet

How to use:
Create a Tag named "Planet"(not in v0)
Apply tag to any bodies that should emit gravity(not in v0)
Make sure the emission objects contain a RigidBody to account for mass (if you don't want them to move, make sure Is Kinematic is checked)
Add the script to the GameObject that should be effected by gravity
Make sure the effected objects contain a RigidBody as well
Set param rb to the effected object's rigidbody
set param obj to the planet object(v0 only!)
Param objrb can be left blank (v0: set to the planets rigidbody) 
Set the gravitational constant to preference
Then you can run the game


