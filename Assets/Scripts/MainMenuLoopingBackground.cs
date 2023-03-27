using UnityEngine;

public class MainMenuLoopingBackground : MonoBehaviour
{
    public float BackgroundSpeed;
    public Renderer BackgroundRenderer;

    void Update()
    {
        BackgroundRenderer.material.mainTextureOffset += new Vector2(0f, BackgroundSpeed * Time.deltaTime);
    }
}
