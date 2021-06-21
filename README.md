Initialize
```c#
    public AdvancedKeyCode toggleInventory = new AdvancedKeyCode(KeyCode.E);
    public AdvancedKeyCode moveForward = KeyCode.W;
    public AdvancedKeyCode moveLeft = KeyCode.A; 
    public AdvancedKeyCode moveBackward = KeyCode.S;
    public AdvancedKeyCode moveRight = KeyCode.D;
```

```c#
    void Update() {
        if(KeyManager.Instance.toggleInventory.GetKeyDown())
            inventory.Toggle();
        
        Vector2 direction = Vector2.zero;
        direction.x += KeyManager.Instance.moveRight.GetKey() ? 1 : 0;
        direction.x -= KeyManager.Instance.moveLeft.GetKey() ? 1 : 0;
        direction.y += KeyManager.Instance.moveForward.GetKey() ? 1 : 0;
        direction.y -= KeyManager.Instance.moveBackward.GetKey() ? 1 : 0;
    }
```
