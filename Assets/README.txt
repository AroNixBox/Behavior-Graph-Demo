Set up the Project:

Download the Free Ghost Asset + Import it into the Project:
https://assetstore.unity.com/packages/3d/characters/creatures/ghost-character-free-267003?srsltid=AfmBOoqZF_hd0VVKgDvwwFqxBxV8YXdyvjtVMBhU1RAclE0Hq_szGMVC

Under Assets/Animation you can find an Animator. 
Assign the Ghost Animation to the States:
Ground Locomotion Blendtree (Idle > ghost_idle, Walk > ghost_run), Set them to loop.
Eat > ghost_surprised
Attack > ghost_attack

Open the Behavior Demo Scene Assets/Scenes/BehaviorDemo
In the Inspector you can find 4 Ghost Variants. Each on has one Child:
Model Root (PARENT OF IMPORTED GHOST). Drag the Ghost Prefab as a child of this GameObject.
Remove the CharacterController and GhostMover Component from the Ghost if it has one.
Link the Animator Components Controller to the one that you edited above: Assets/Animation.
On the Animator Component, assign the Ghost Avatar.
Each Ghost Variant has a Behavior Agent Component, the BlackboardVariable "Animator"
needs a reference to the Animator Component of your Ghost.

Have fun!