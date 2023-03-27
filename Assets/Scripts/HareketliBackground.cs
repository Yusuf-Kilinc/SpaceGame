using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HareketliBackground : MonoBehaviour
{
    public float BackgroundSpeed;
    public Renderer BackgroundRenderer;
    public List<Texture> textures;
    public int textureControls;
    public float sayac;
    public Score ScoreEdith;

    private void Start()
    {
        BackgroundRenderer = GetComponent<Renderer>();
        sayac = 15;
    }

    void Update()
    {
        #region Devre Dýþý
        //if (ScoreEdith.score > 0.0001f && ScoreEdith.score < 20)
        //{
        //    BackgroundRenderer.material.mainTexture = texture0;
        //}
        //if (ScoreEdith.score >= 20 && ScoreEdith.score < 40)
        //{
        //    BackgroundRenderer.material.mainTexture = texture1;
        //}
        //if (ScoreEdith.score >= 40 && ScoreEdith.score < 60)
        //{
        //    BackgroundRenderer.material.mainTexture = texture2;
        //}
        //if (ScoreEdith.score >= 60 && ScoreEdith.score < 80)
        //{
        //    BackgroundRenderer.material.mainTexture = texture3;
        //}
        //if (ScoreEdith.score >= 80 && ScoreEdith.score < 100)
        //{
        //    BackgroundRenderer.material.mainTexture = texture4;
        //}
        //if (ScoreEdith.score >= 100 && ScoreEdith.score < 120)
        //{
        //    BackgroundRenderer.material.mainTexture = texture5;
        //}
        #endregion

        // StartCoroutine("BackGroundControl");

        if (sayac > 0)
        {
            sayac -= 1 * Time.deltaTime;

            textureControls = Random.Range(0, 6);
        }
        if (sayac <= 0)
        {
            sayac = 15;
        }
        if (sayac > 15)
        {
            sayac = 15;
        }


        #region Float Kontrol sistemi
        if (textureControls == 1)
        {
            BackgroundRenderer.material.mainTexture = textures[0];
        }
        if (textureControls == 2)
        {
            BackgroundRenderer.material.mainTexture = textures[1];
        }
        if (textureControls == 3)
        {
            BackgroundRenderer.material.mainTexture = textures[2];
        }
        if (textureControls == 4)
        {
            BackgroundRenderer.material.mainTexture = textures[3];
        }
        if (textureControls == 5)
        {
            BackgroundRenderer.material.mainTexture = textures[4];
        }
        if (textureControls == 6)
        {
            BackgroundRenderer.material.mainTexture = textures[5];
        }
        #endregion

        BackgroundRenderer.material.mainTextureOffset += new Vector2(BackgroundSpeed * Time.deltaTime, 0f);
    }


    private void BackGround()
    {
        textureControls = Random.Range(0, 6);

        #region Float Kontrol sistemi
        //if (textureControls == 1)
        //{
        //    BackgroundRenderer.material = Materials[0];
        //}
        //if (textureControls == 2)
        //{
        //    BackgroundRenderer.material = Materials[1];
        //}
        //if (textureControls == 3)
        //{
        //    BackgroundRenderer.material = Materials[2];
        //}
        //if (textureControls == 4)
        //{
        //    BackgroundRenderer.material = Materials[3];
        //}
        //if (textureControls == 5)
        //{
        //    BackgroundRenderer.material = Materials[4];
        //}
        //if (textureControls == 6)
        //{
        //    BackgroundRenderer.material = Materials[5];
        //}
        #endregion

    }

    IEnumerator BackGroundControl()
    {
        yield return new WaitForSeconds(10);
        StartCoroutine("BackGround");

        // textureControls = Random.Range(0, 6);
    }
}
