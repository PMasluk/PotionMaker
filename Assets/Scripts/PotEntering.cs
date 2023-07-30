using UnityEngine;

public class PotEntering : MonoBehaviour
{
    [SerializeField]
    private IndexAssigner assignIndex;
    private void Update()
    {
        if ((transform.position.y > 0.5f && transform.position.y < 1) && (transform.position.x > -2.5f && transform.position.x < -1.5f))
        {
            //PotionListMaker.Instance.AddToList(assignIndex.GettingIndex);
            RecipesBase.Instance.CompareIngradientWithRecipe(assignIndex.GettingIndex);
            gameObject.SetActive(false);
        }
    }
}