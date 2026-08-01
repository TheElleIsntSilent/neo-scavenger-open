# Inventory Design Decisions

## Glossary

| Term | Description |
| -------- | -------- |
| Actor | PC or NPC; anything that can move around on the overworld Location Tiles |
| Object | Anything that can appear on a 2D grid; Physical Items, Traits/Flaws, Cutscene Actions, Hideout Selection icons, etc. Has a 2D Size and orientation. |
| Container | Anything that can contain Objects. Has a 2D Size. |
| Accessible (Container) | Container contents can be used for crafting |
| Inaccessible (Container) | Container contents cannot be used for crafting.
| Open (Container) | Container contents are on display and can be Moused-Over / Clicked. Mousing over a Container Object within an Open Container will Open the Container in an Information Window, but since the Information Window is Anchored to the Cursor, the items within cannot be Moused Over or Clicked |
| Closed (Container) | Container contents are not on display. |


## Quirks and Intended Behavior

Neo Scavenger has a number of fun little quirks that make engine recreation an interesting challenge. 

### Objects and Containers as a core gameplay element

Neo Scavenger uses while I'll call Objects and Containers as a core game system:
- Trait / Flaw selection
- Cutscene Action selection
- Item containers
  - Equipment slots
  - Location Tile contents
    - Vendor contents
  - Hideout contents
  - Vehicle / Bag contents
- Crafting
- Hideout Location selection

These systems have common behavior:
- Containers are composed of a 2D grid of Slots and are of size 1x1 or larger.
- Objects all have a 2D shape of 1x1 or larger.
- Containers can contain Objects, and the set of Slots that the Object covers are occupied.
- Containers can be Accessible or Inaccessible.
  - Actors can only Access Location Tile / Hideout contents for their current Location.
  - Crafting can only be done with items in Accessible locations.
- Objects in Accessible Containers can be moused-over.
  - Physical Items show an Information Window with a Name, Weight, Value, and Durability.
  - Hideouts show Name and Value.
  - Containers additionally show contents.
- Objects in Accessible Containers can be Left-Clicked.
  - Items/Traits/Cutscene Choices can be picked up or sent to the Default Target Container (depending on click mode).
  - Clicking a Hideout will move the player to that Hideout (Making the previous Hideout Inaccessible, and making the chosen Hideout Accessible).
- Objects
  
