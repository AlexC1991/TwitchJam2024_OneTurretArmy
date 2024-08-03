using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace OneTurretArmy
{
    public class PathGenerationLayerScript : MonoBehaviour
    {
        [SerializeField] public List<GameObject> tileReference = new List<GameObject>();
        [SerializeField] private PathDataBase pDB;
        private RectTransform rectTransform;
        public void AddToArray(GameObject theTile)
        {
            tileReference.Add(theTile);
        }

        public IEnumerator AddInPathGenerator()
        {
            int randomStart = Random.Range(1, 23);

            int numberToContinue = randomStart;
            
            tileReference[numberToContinue -1].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue - 1].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue - 1].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue +1].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 1].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 1].GetComponent<RectTransform>().rotation = rectTransform.rotation;

            while (numberToContinue != tileReference.Count)
            {
                yield return new WaitForSeconds(0.01f);
                numberToContinue += 25;

                    tileReference[numberToContinue -1].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
                    rectTransform = tileReference[randomStart - 1].GetComponent<RectTransform>();
                    rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
                    tileReference[numberToContinue - 1].GetComponent<RectTransform>().rotation = rectTransform.rotation;
                    tileReference[numberToContinue].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
                    tileReference[numberToContinue +1].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
                    rectTransform = tileReference[numberToContinue + 1].GetComponent<RectTransform>();
                    rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
                    tileReference[numberToContinue + 1].GetComponent<RectTransform>().rotation = rectTransform.rotation;

                yield return null;
            }
            
        }
    }
}
