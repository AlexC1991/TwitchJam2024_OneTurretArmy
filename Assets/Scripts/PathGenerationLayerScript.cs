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
        private int numberToContinue;
        public void AddToArray(GameObject theTile)
        {
            tileReference.Add(theTile);
        }

        public IEnumerator AddInPathGenerator()
        {
            int randomStart = Random.Range(4, 20);

            numberToContinue = randomStart;
            
            tileReference[numberToContinue -1].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue - 1].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue - 1].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue +1].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 1].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 1].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            numberToContinue += 25;
            
            
                yield return new WaitForSeconds(0.01f);
                StartCoroutine(CurvePathDownRight());
                yield return new WaitForSeconds(0.01f);
                StartCoroutine(StraightPathBelow());
                yield return new WaitForSeconds(0.01f);
                StartCoroutine(CurvePathUpRight());
                yield return new WaitForSeconds(0.01f);
                StartCoroutine(StriaghtPathMidPoint());
                yield return new WaitForSeconds(0.01f);
                StartCoroutine(CurvePathUpRightTop());
               
                
        }

        private IEnumerator StriaghtPathMidPoint()
        {
            tileReference[numberToContinue - 1].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue - 1].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue - 1].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 1].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 1].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 1].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            numberToContinue += 25;
            yield return null;
        }

        private IEnumerator CurvePathDownRight()
        {  
            tileReference[numberToContinue - 4].GetComponent<Image>().sprite = pDB.pathData[5].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue - 4].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, -90f);
            tileReference[numberToContinue - 4].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue - 3].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            tileReference[numberToContinue - 2].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            tileReference[numberToContinue - 1].GetComponent<Image>().sprite = pDB.pathData[3].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue - 1].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, -90f);
            tileReference[numberToContinue - 1].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 1].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 1].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 1].GetComponent<RectTransform>().rotation = rectTransform.rotation;
           
            numberToContinue += 25;
            // Start to Curve Down
            tileReference[numberToContinue - 4].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue - 4].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue - 4].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue - 3].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue - 2].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue - 1].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 1].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 1].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 1].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            
            numberToContinue += 25;
            // Starting to Stright
            tileReference[numberToContinue - 4].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue - 4].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue - 4].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue - 3].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue - 2].GetComponent<Image>().sprite = pDB.pathData[3].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue - 2].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue - 2].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue - 1].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            tileReference[numberToContinue].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            tileReference[numberToContinue + 1].GetComponent<Image>().sprite = pDB.pathData[5].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 1].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 1].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            
            numberToContinue += 25;
            // Striaght Track
            
            tileReference[numberToContinue - 4].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue - 4].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue - 4].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue - 3].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue - 2].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue - 2].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue - 2].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            
            yield return null;
        }

        private IEnumerator CurvePathUpRight()
        {
            tileReference[numberToContinue - 4].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue - 4].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue - 4].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue - 3].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue - 2].GetComponent<Image>().sprite = pDB.pathData[3].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue - 2].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 180f);
            tileReference[numberToContinue - 2].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue - 1].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            tileReference[numberToContinue].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            tileReference[numberToContinue + 1].GetComponent<Image>().sprite = pDB.pathData[5].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 1].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 180f);
            tileReference[numberToContinue + 1].GetComponent<RectTransform>().rotation = rectTransform.rotation;
           
            numberToContinue += 25;
            // Start to Curve Up
            tileReference[numberToContinue - 4].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue - 4].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue - 4].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue - 3].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue - 2].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue - 1].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 1].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 1].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 1].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            
            numberToContinue += 25;
            // Starting to Stright
            tileReference[numberToContinue - 4].GetComponent<Image>().sprite = pDB.pathData[5].pathSprite.sprite;
            tileReference[numberToContinue - 3].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            tileReference[numberToContinue - 2].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            tileReference[numberToContinue - 1].GetComponent<Image>().sprite = pDB.pathData[3].pathSprite.sprite;
            tileReference[numberToContinue].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 1].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 1].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 1].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            
            numberToContinue += 25;
            // Striaght Track
            
            tileReference[numberToContinue - 1].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue - 1].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue - 1].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 1].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 1].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 1].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            numberToContinue += 25;
            
            yield return null;
        }

        private IEnumerator StraightPathBelow()
        {
            tileReference[numberToContinue - 4].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue - 4].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue - 4].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue - 3].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue - 2].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue - 2].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue - 2].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            numberToContinue += 25;
            yield return null;
        }

        private IEnumerator CurvePathUpRightTop()
        {
            tileReference[numberToContinue - 1].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue - 1].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue - 1].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 1].GetComponent<Image>().sprite = pDB.pathData[3].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 1].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 180f);
            tileReference[numberToContinue + 1].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue + 2].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            tileReference[numberToContinue + 3].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            tileReference[numberToContinue + 4].GetComponent<Image>().sprite = pDB.pathData[5].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 4].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 180f);
            tileReference[numberToContinue + 4].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            
            numberToContinue += 25;
            // Start to Curve Up
            tileReference[numberToContinue - 1].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue - 1].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue - 1].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 1].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 2].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 3].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 4].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 4].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 4].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            
            numberToContinue += 25;
            // Starting to Stright
            tileReference[numberToContinue + 1].GetComponent<Image>().sprite = pDB.pathData[5].pathSprite.sprite;
            tileReference[numberToContinue].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            tileReference[numberToContinue + 1].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            tileReference[numberToContinue + 2].GetComponent<Image>().sprite = pDB.pathData[3].pathSprite.sprite;
            tileReference[numberToContinue + 3].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 4].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 4].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 4].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            
            numberToContinue += 25;
            // Striaght Track
            
            tileReference[numberToContinue + 2].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 2].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 2].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue + 3].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 4].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 4].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 4].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            numberToContinue += 25;
            
            yield return null;
        }
         

    }
}
