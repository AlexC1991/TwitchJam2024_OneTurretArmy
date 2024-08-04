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
        private int trackToPutIn;
        public void AddToArray(GameObject theTile)
        {
            tileReference.Add(theTile);
        }

        private IEnumerator AddInPathGenerator()
        {
            int randomStart =  Random.Range(4, 13);

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

            while (numberToContinue < 1100)
            {
                int selectedCase = Random.Range(0, 1);
            }

            switch (trackToPutIn)
            {
                case 0:
                    StartCoroutine(StriaghtPathMidPoint());
                    break;
                case 1:
                    StartCoroutine(CurvePathDownRight());
                    break;
                case 2:
                    StartCoroutine(CurvePathUpRight());
                    break;
                case 3:
                    StartCoroutine(StraightPathBelow());
                    break;
                case 4:
                    StartCoroutine(CurvePathUpRightTop());
                    break;
                case 5:
                    StartCoroutine(CurvePathDownRightAbove());
                    break;
                case 6:
                    StartCoroutine(CurvePathStraightUpMid());
                    break;
                case 7:
                    StartCoroutine(StriaghtVerticlePathAbove());
                    break;
                case 8:
                    StartCoroutine(StraighVerticlePathHighestPoint());
                    break;
                case 9:
                    StartCoroutine(StraightHorizontalPathHighestPoint());
                    break;
                case 10:
                    StartCoroutine(CurvePathDownRightHighestPoint());
                    break;
                case 11:
                    StartCoroutine(StraightHorizontalPathMidHighPoint());
                    break;
                case 12:
                    StartCoroutine(CurvePathDownRightMidHighPoint());
                    break;
                case 13:
                    StartCoroutine(CurvePathDownRightLowestHighToMidPoint());
                    break;
            }

            yield return null;
        }
        
        // Different Sections of Path To Call To.
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

        private IEnumerator CurvePathDownRightAbove()
        {
            tileReference[numberToContinue - 1].GetComponent<Image>().sprite = pDB.pathData[5].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue - 1].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, -90f);
            tileReference[numberToContinue - 1].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            tileReference[numberToContinue + 1].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            tileReference[numberToContinue + 2].GetComponent<Image>().sprite = pDB.pathData[3].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 2].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, -90f);
            tileReference[numberToContinue + 2].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue + 3].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 4].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 4].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 4].GetComponent<RectTransform>().rotation = rectTransform.rotation;
           
            numberToContinue += 25;
            // Start to Curve Down
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
            tileReference[numberToContinue - 1].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue - 1].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue - 1].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 1].GetComponent<Image>().sprite = pDB.pathData[3].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 1].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 1].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue + 2].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            tileReference[numberToContinue + 3].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            tileReference[numberToContinue + 4].GetComponent<Image>().sprite = pDB.pathData[5].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 4].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 4].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            
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
            
            yield return null;
        }

        private IEnumerator CurvePathStraightUpMid()
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
            
            numberToContinue += 25;
            // Starting to Stright
            tileReference[numberToContinue + 1].GetComponent<Image>().sprite = pDB.pathData[5].pathSprite.sprite;
            tileReference[numberToContinue].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            tileReference[numberToContinue + 1].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            tileReference[numberToContinue + 2].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
           
            numberToContinue += 25;
            yield return null;
        }

        private IEnumerator StriaghtVerticlePathAbove()
        {
            numberToContinue -= 75;
            
            tileReference[numberToContinue + 3].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            tileReference[numberToContinue + 4].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            tileReference[numberToContinue + 5].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            tileReference[numberToContinue + 6].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
           
            numberToContinue += 25;
            // Start to Curve Up
            tileReference[numberToContinue + 3].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 4].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 5].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 6].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            
            numberToContinue += 25;
            // Starting to Stright
            tileReference[numberToContinue + 3].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            tileReference[numberToContinue + 4].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            tileReference[numberToContinue + 5].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            tileReference[numberToContinue + 6].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            
            numberToContinue += 25;
            yield return null;
        }

        private IEnumerator StraighVerticlePathHighestPoint()
        {
            numberToContinue -= 75;
            
            tileReference[numberToContinue + 7].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            tileReference[numberToContinue + 8].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            tileReference[numberToContinue + 9].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            tileReference[numberToContinue + 10].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            tileReference[numberToContinue + 11].GetComponent<Image>().sprite = pDB.pathData[5].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 11].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 180f);
            tileReference[numberToContinue + 11].GetComponent<RectTransform>().rotation = rectTransform.rotation;
           
            numberToContinue += 25;
            // Start to Curve Up
            tileReference[numberToContinue + 7].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 8].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 9].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 10].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 11].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 11].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 11].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            
            numberToContinue += 25;
            // Starting to Stright
            tileReference[numberToContinue + 7].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            tileReference[numberToContinue + 8].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            tileReference[numberToContinue + 9].GetComponent<Image>().sprite = pDB.pathData[3].pathSprite.sprite;
            tileReference[numberToContinue + 10].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 11].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 11].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 11].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            
            numberToContinue += 25;
            yield return null;
        }

        private IEnumerator StraightHorizontalPathHighestPoint()
        {
            tileReference[numberToContinue + 9].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 9].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 9].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue + 10].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 11].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 11].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 11].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            numberToContinue += 25;
            yield return null;
        }

        private IEnumerator CurvePathDownRightHighestPoint()
        {
            tileReference[numberToContinue + 6].GetComponent<Image>().sprite = pDB.pathData[5].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 6].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, -90f);
            tileReference[numberToContinue + 6].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue + 7].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            tileReference[numberToContinue + 8].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            tileReference[numberToContinue + 9].GetComponent<Image>().sprite = pDB.pathData[3].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 9].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, -90f);
            tileReference[numberToContinue + 9].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue + 10].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 11].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 11].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 11].GetComponent<RectTransform>().rotation = rectTransform.rotation;
           
            numberToContinue += 25;
            // Start to Curve Down
            tileReference[numberToContinue + 6].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 6].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 6].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue + 7].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 8].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 9].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 10].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 11].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 11].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 11].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            
            numberToContinue += 25;
            // Starting to Stright
            tileReference[numberToContinue + 6].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 6].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 6].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue + 7].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 8].GetComponent<Image>().sprite = pDB.pathData[3].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 8].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 8].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue + 9].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            tileReference[numberToContinue + 10].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            tileReference[numberToContinue + 11].GetComponent<Image>().sprite = pDB.pathData[5].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 11].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 11].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            
            numberToContinue += 25;
            // Striaght Track
            
            tileReference[numberToContinue + 6].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 6].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 6].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue + 7].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 8].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 8].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 8].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            numberToContinue += 25;
            yield return null;
        }
        
        private IEnumerator StraightHorizontalPathMidHighPoint()
        {
            tileReference[numberToContinue + 6].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 6].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 6].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue + 7].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 8].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 8].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 8].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            
            numberToContinue += 25;
            yield return null;
        }
        
        private IEnumerator CurvePathDownRightMidHighPoint()
        {
            tileReference[numberToContinue + 3].GetComponent<Image>().sprite = pDB.pathData[5].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 3].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, -90f);
            tileReference[numberToContinue + 3].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue + 4].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            tileReference[numberToContinue + 5].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            tileReference[numberToContinue + 6].GetComponent<Image>().sprite = pDB.pathData[3].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 6].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, -90f);
            tileReference[numberToContinue + 6].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue + 7].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 8].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 8].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 8].GetComponent<RectTransform>().rotation = rectTransform.rotation;
           
            numberToContinue += 25;
            // Start to Curve Down
            tileReference[numberToContinue + 3].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 3].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 3].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue + 4].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 5].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 6].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 7].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 8].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 8].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 8].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            
            numberToContinue += 25;
            // Starting to Stright
            tileReference[numberToContinue + 3].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 3].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 3].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue + 4].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 5].GetComponent<Image>().sprite = pDB.pathData[3].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 5].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 5].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue + 6].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            tileReference[numberToContinue + 7].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            tileReference[numberToContinue + 8].GetComponent<Image>().sprite = pDB.pathData[5].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 8].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 8].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            
            numberToContinue += 25;
            // Striaght Track
            
            tileReference[numberToContinue + 3].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 3].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 3].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue + 4].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 5].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 5].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 5].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            numberToContinue += 25;
            yield return null;
        }
        
        private IEnumerator CurvePathDownRightLowestHighToMidPoint()
        {
            tileReference[numberToContinue - 1].GetComponent<Image>().sprite = pDB.pathData[5].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue - 1].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, -90f);
            tileReference[numberToContinue - 1].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            tileReference[numberToContinue + 1].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            tileReference[numberToContinue + 2].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            tileReference[numberToContinue + 3].GetComponent<Image>().sprite = pDB.pathData[3].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 3].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, -90f);
            tileReference[numberToContinue + 3].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue + 4].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 5].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 5].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 5].GetComponent<RectTransform>().rotation = rectTransform.rotation;
           
            numberToContinue += 25;
            // Start to Curve Down
            tileReference[numberToContinue - 1].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue - 1].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue - 1].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 1].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 2].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 3].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 4].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 5].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 5].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 5].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            
            numberToContinue += 25;
            // Starting to Stright
            tileReference[numberToContinue - 1].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue - 1].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue - 1].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 1].GetComponent<Image>().sprite = pDB.pathData[3].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 1].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 1].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue + 2].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            tileReference[numberToContinue + 3].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            tileReference[numberToContinue + 4].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            tileReference[numberToContinue + 5].GetComponent<Image>().sprite = pDB.pathData[5].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 5].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 5].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            
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
        
        
        
        
        
        
        
        // Starting Phase of making the Barrier
        public IEnumerator StartingLevelBarrier()
        {
            int startingPoint = 0;
            
            while (startingPoint < 25)
            {
                yield return new WaitForSeconds(0.02f);
                tileReference[startingPoint].GetComponent<Image>().sprite = pDB.pathData[6].pathSprite.sprite;
                startingPoint++;
            }

            if (startingPoint == 25)
            {
                StartCoroutine(StartingLevelBarrier2Bottom());
                StartCoroutine(StartingLevelBarrier2Top());

            }
            yield return null;
        }

       private IEnumerator StartingLevelBarrier2Bottom()
       {
           int counterBottom = 0;
           int startingPointTwo = 25;
            while (counterBottom < 43)
            {
                tileReference[startingPointTwo].GetComponent<Image>().sprite = pDB.pathData[6].pathSprite.sprite;
                startingPointTwo += 25;
                counterBottom++;
            }
            yield return null;
        }
       
        private IEnumerator StartingLevelBarrier2Top()
        {
            int counterTop = 0;
            int startingPositionTwoTop = 24;
            while (counterTop < 43)
            {
                tileReference[startingPositionTwoTop].GetComponent<Image>().sprite = pDB.pathData[6].pathSprite.sprite;
                startingPositionTwoTop += 25;
                counterTop++;
            }
            
            if (counterTop == 43)
            {
                StartCoroutine(StartingLevelBarrierFinish());
            }
            yield return null;
        }
        
        private IEnumerator StartingLevelBarrierFinish()
        {
            int startingPoint3 = 1075;
            
            while (startingPoint3 < 1100)
            {
                yield return new WaitForSeconds(0.02f);
                tileReference[startingPoint3].GetComponent<Image>().sprite = pDB.pathData[6].pathSprite.sprite;
                startingPoint3++;
            }

            if (startingPoint3 == 1100)
            {
                StartCoroutine(AddInPathGenerator());
            }
            yield return null;
        }
    }
}
