# DialogueSystem
This plugin provides a solution for the Dialogue system in the mobile or touch based games for unity. You don't need to program anything, just create characters, chats in the project window and use them in the game. This project uses the Scriptable object functionality to make this flow user friendly, so that the game designer or art any one with zero knowledge of programming can use this to create a Dialogue system.

## Issues
- You need TextMesh Pro(TMP) Essentials to work with this. I tried making a unity package but it won't go in that. Just install TMP and make a TMP text in heirarchy, unity will ask you to install TMP essentials, click install.

## Instructions
- In the prefab folder you can find Canvas and a Dialogue parent prefab. if you prefer to use your own canvas, please adjust the UI elements to fit your screen or you can set "canvas scaler" component values as, 
  - UI Scale Mode - Scale with screen size
  - Reference Resolution - X 1920 Y 1080
  - Screen Match Mode - Match Width Or Height
  - Match - 0.5

- Drag Dialogue parent prefab in your canvas, with this prefab, you can find ChatManager.cs script attached. It contains references to everthing.
- However, Chat Object and CHaracter object are empty, we'll be creating those and assigninig them here.
- Till here we have set up the scene, next is creating dialogues, characters, etc.
---
### Creating Scriptable Objects
- Right-click in project window -> Create -> ChatData
- Here in ChatData, you can find all the things you need to create for a Dialogue system.
- In ChatData click on Characters, Name the file same as your character
    - Now, select characterfile you just created, look in Inspector window
    - Giving CharacterName is optional, it'l take the name from the fileName.
    - Give it a character png image in character image.
    - Give it a character List to which this character belongs to, or create a new charater list.
- Now let's create a charater list, you can assign characters here or in character files provide the character list and Click on save profile button.
- Now same way create Chat from ChatData.
  - Click on + button in inspector, you'll get an element.
  - Here Assign the character, whose dialogue it is.
  - Choose side on which side of the screen it'll appear.
  - Provide the dialogue as text.
---
- That's it assign CharacterList and Chat scriptable objects in Chat Manager.
- Play the scene.
---
---
## Upcoming features
- Character names along with their images.
- Scrollable chat, as new chat box appears, the old chat moves up or down.
- Improving Chat Manager script


