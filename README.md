# DialogueSystem
This plugin provides a solution for the Dialogue system in the mobile or touch based games for unity. You don't need to program anything, just create characters, chats in the project window and use them in the game. This project uses the Scriptable object functionality to make this flow user friendly, so that the game designer or art any one with zero knowledge of programming can use this to create a Dialogue system.

### Issues
- You need TextMesh Pro(TMP) Essentials to work with this. I tried making a unity package but it won't go in that. Just install TMP and make a TMP text in heirarchy, unity will ask you to install TMP essentials, click install.

### Instructions
- In the prefab folder you can find Canvas and a Dialogue parent prefab. if you prefer to use your own canvas, please adjust the UI elements to fit your screen or you can set "canvas scaler" component values as, 
- - UI Scale Mode - Scale with screen size
- - Reference Resolution - X 1920 Y 1080
- - Screen Match Mode - Match Width Or Height
- - Match - 0.5

- Drag Dialogue parent prefab in your canvas, with this prefab, you can find ChatManager.cs script attached. It contains references to everthing.
- However, Chat Object and CHaracter object are empty, we'll be creating those and assigninig them here.
- 
