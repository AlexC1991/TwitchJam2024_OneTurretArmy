using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

namespace OneTurretArmy
{
    public class PathGenerationLayerScript : MonoBehaviour
    {
        [SerializeField] public List<GameObject> tileReference = new List<GameObject>();
        [SerializeField] private PathDataBase pDB;
        [SerializeField] private ButtonMapUIController bMC;
        private RectTransform rectTransform;
        private int numberToContinue;
        private int trackToPutIn;
        private int selectedCase;

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
           
            StartCoroutine(NextPathPlease());
            yield return null;
        }

        // Sequence of Events for Random Path Generation.
        private IEnumerator NextPathPlease()
        {
            Debug.Log("Tiles It's Up To: " + numberToContinue);
            
            if (numberToContinue < tileReference.Count)
            {
                yield return new WaitForSeconds(0.2f);
                selectedCase = Random.Range(0, 3);
                StartCoroutine(CheckStatementsFirst());
            }
            else
            {
                Debug.Log("Finished Implementing Path Structure");
            }
            
            yield return null;
        }

        private IEnumerator CheckStatementsFirst()
        {
            // trackToPutIn 0 = Straight Path Along 0 Line
                if (selectedCase == 0 && trackToPutIn == 0)
                {
                    trackToPutIn = 0;
                    CheckSwitchCase();
                }
                else if (selectedCase == 1 && trackToPutIn == 0)
                {
                    trackToPutIn = 1;
                    CheckSwitchCase();
                }
                else if (selectedCase == 2 && trackToPutIn == 0)
                {
                    trackToPutIn = 4;
                    CheckSwitchCase();
                }
                else if (selectedCase == 3 && trackToPutIn == 0)
                {
                    trackToPutIn = 6;
                    CheckSwitchCase();
                }
                
                // trackToPutIn 1 = Along the -3 Line from line 0
                if (selectedCase == 0 && trackToPutIn == 1)
                {
                    trackToPutIn = 2;
                    CheckSwitchCase();
                }
                else if (selectedCase == 1 && trackToPutIn == 1)
                {
                    trackToPutIn = 2;
                    CheckSwitchCase();
                }
                else if (selectedCase == 2 && trackToPutIn == 1)
                {
                    trackToPutIn = 3;
                    CheckSwitchCase();
                }
                else if (selectedCase == 3 && trackToPutIn == 1)
                {
                    trackToPutIn = 3;
                    CheckSwitchCase();
                }
                
                // trackToPutIn 2 = Goes Down to -3 from line 0.
                if (selectedCase == 0 && trackToPutIn == 2)
                {
                    trackToPutIn = 0;
                    CheckSwitchCase();
                }
                else if (selectedCase == 1 && trackToPutIn == 2)
                {
                    trackToPutIn = 1;
                    CheckSwitchCase();
                }
                else if (selectedCase == 2 && trackToPutIn == 2)
                {
                    trackToPutIn = 4;
                    CheckSwitchCase();
                }
                else if (selectedCase == 3 && trackToPutIn == 2)
                {
                    trackToPutIn = 6;
                    CheckSwitchCase();
                }
                
                // trackToPutIn 3 = Along the 0 Line from -3
                if (selectedCase == 0 && trackToPutIn == 3)
                {
                    trackToPutIn = 0;
                    CheckSwitchCase();
                }
                else if (selectedCase == 1 && trackToPutIn == 3)
                {
                    trackToPutIn = 1;
                    CheckSwitchCase();
                }
                else if (selectedCase == 2 && trackToPutIn == 3)
                {
                    trackToPutIn = 4;
                    CheckSwitchCase();
                }
                else if (selectedCase == 3 && trackToPutIn == 3)
                {
                    trackToPutIn = 6;
                    CheckSwitchCase();
                }
                
                
                // trackToPutIn 4 = Goes Up to + 3 from line 0.
                if (selectedCase == 0 && trackToPutIn == 4)
                {
                    trackToPutIn = 5;
                    CheckSwitchCase();
                }
                else if (selectedCase == 1 && trackToPutIn == 4)
                {
                    trackToPutIn = 5;
                    CheckSwitchCase();
                }
                else if (selectedCase == 2 && trackToPutIn == 4)
                {
                    trackToPutIn = 5;
                    CheckSwitchCase();
                }
                else if (selectedCase == 3 && trackToPutIn == 4)
                {
                    trackToPutIn = 5;
                    CheckSwitchCase();
                }
                
                // trackToPutIn 5 = Goes From Line + 3 to Line 0.
                if (selectedCase == 0 && trackToPutIn == 5)
                {
                    trackToPutIn = 0;
                    CheckSwitchCase();
                }
                else if (selectedCase == 1 && trackToPutIn == 5)
                {
                    trackToPutIn = 1;
                    CheckSwitchCase();
                }
                else if (selectedCase == 2 && trackToPutIn == 5)
                {
                    trackToPutIn = 4;
                    CheckSwitchCase();
                }
                else if (selectedCase == 3 && trackToPutIn == 5)
                {
                    trackToPutIn = 6;
                    CheckSwitchCase();
                }
                
                // trackToPutIn 6 = Goes Up from Line 0 to Line + 3 Straight No Curve.
                if (selectedCase == 0 && trackToPutIn == 6)
                {
                    trackToPutIn = 7;
                    CheckSwitchCase();
                }
                else if (selectedCase == 1 && trackToPutIn == 6)
                {
                    trackToPutIn = 7;
                    CheckSwitchCase();
                }
                else if (selectedCase == 2 && trackToPutIn == 6)
                {
                    trackToPutIn = 7;
                    CheckSwitchCase();
                }
                else if (selectedCase == 3 && trackToPutIn == 6)
                {
                    trackToPutIn = 7;
                    CheckSwitchCase();
                }
                
                // trackToPutIn 7 = Goes From Line + 3 to Line + 6.
                if (selectedCase == 0 && trackToPutIn == 7)
                {
                    trackToPutIn = 8;
                    CheckSwitchCase();
                }
                else if (selectedCase == 1 && trackToPutIn == 7)
                {
                    trackToPutIn = 8;
                    CheckSwitchCase();
                }
                else if (selectedCase == 2 && trackToPutIn == 7)
                {
                    trackToPutIn = 8;
                    CheckSwitchCase();
                }
                else if (selectedCase == 3 && trackToPutIn == 7)
                {
                    trackToPutIn = 8;
                    CheckSwitchCase();
                }
                
                // trackToPutIn 8 = Goes From Line + 6 to Line + 10.
                if (selectedCase == 0 && trackToPutIn == 8)
                {
                    trackToPutIn = 9;
                    CheckSwitchCase();
                }
                else if (selectedCase == 1 && trackToPutIn == 8)
                {
                    trackToPutIn = 10;
                    CheckSwitchCase();
                }
                else if (selectedCase == 2 && trackToPutIn == 8)
                {
                    trackToPutIn = 10;
                    CheckSwitchCase();
                }
                else if (selectedCase == 3 && trackToPutIn == 8)
                {
                    trackToPutIn = 9;
                    CheckSwitchCase();
                }
                
                // trackToPutIn 9 = Goes Striaght Along Line + 10.
                if (selectedCase == 0 && trackToPutIn == 9)
                {
                    trackToPutIn = 10;
                    CheckSwitchCase();
                }
                else if (selectedCase == 1 && trackToPutIn == 9)
                {
                    trackToPutIn = 10;
                    CheckSwitchCase();
                }
                else if (selectedCase == 2 && trackToPutIn == 9)
                {
                    trackToPutIn = 10;
                    CheckSwitchCase();
                }
                else if (selectedCase == 3 && trackToPutIn == 9)
                {
                    trackToPutIn = 10;
                    CheckSwitchCase();
                }
                
                // trackToPutIn 10 = Goes From Line + 10 to Line + 7.
                if (selectedCase == 0 && trackToPutIn == 10)
                {
                    trackToPutIn = 11;
                    CheckSwitchCase();
                }
                else if (selectedCase == 1 && trackToPutIn == 10)
                {
                    trackToPutIn = 12;
                    CheckSwitchCase();
                }
                else if (selectedCase == 2 && trackToPutIn == 10)
                {
                    trackToPutIn = 12;
                    CheckSwitchCase();
                }
                else if (selectedCase == 3 && trackToPutIn == 10)
                {
                    trackToPutIn = 11;
                    CheckSwitchCase();
                }
                
                // trackToPutIn 11 = Goes Striaght Along Line + 7.
                if (selectedCase == 0 && trackToPutIn == 11)
                {
                    trackToPutIn = 11;
                    CheckSwitchCase();
                }
                else if (selectedCase == 1 && trackToPutIn == 11)
                {
                    trackToPutIn = 12;
                    CheckSwitchCase();
                }
                else if (selectedCase == 2 && trackToPutIn == 11)
                {
                    trackToPutIn = 12;
                    CheckSwitchCase();
                }
                else if (selectedCase == 3 && trackToPutIn == 11)
                {
                    trackToPutIn = 11;
                    CheckSwitchCase();
                }
                
                // trackToPutIn 12 = Goes From Line + 7 to Line + 4.
                if (selectedCase == 0 && trackToPutIn == 12)
                {
                    trackToPutIn = 13;
                    CheckSwitchCase();
                }
                else if (selectedCase == 1 && trackToPutIn == 12)
                {
                    trackToPutIn = 13;
                    CheckSwitchCase();
                }
                else if (selectedCase == 2 && trackToPutIn == 12)
                {
                    trackToPutIn = 13;
                    CheckSwitchCase();
                }
                else if (selectedCase == 3 && trackToPutIn == 12)
                {
                    trackToPutIn = 13;
                    CheckSwitchCase();
                }
                
                // trackToPutIn 13 = Goes From Line + 4 to Line 0.
                if (selectedCase == 0 && trackToPutIn == 13)
                {
                    trackToPutIn = 0;
                    CheckSwitchCase();
                }
                else if (selectedCase == 1 && trackToPutIn == 13)
                {
                    trackToPutIn = 1;
                    CheckSwitchCase();
                }
                else if (selectedCase == 2 && trackToPutIn == 13)
                {
                    trackToPutIn = 4;
                    CheckSwitchCase();
                }
                else if (selectedCase == 3 && trackToPutIn == 13)
                {
                    trackToPutIn = 6;
                    CheckSwitchCase();
                }

                yield return null;
        }

        private void CheckSwitchCase()
        {
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
        }
        
        public void ClearAndResetPath()
        {
            for (int i = 0; i < tileReference.Count; i++)
            {
                tileReference[i].GetComponent<Image>().sprite = pDB.pathData[7].pathSprite.sprite;
            }
            bMC.TurnButtonsOff();
            numberToContinue = 0;
            selectedCase = 0;
            trackToPutIn = 0;
            StartCoroutine(StartingLevelBarrier());
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
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
            
            if (numberToContinue < tileReference.Count)
            {
                StartCoroutine(NextPathPlease());
            }
            else
            {
                bMC.TurnButtonsBackOn();
                Debug.Log("Finished Implementing Path Structure");
            }
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
           
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
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
            
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
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
            
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
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
            
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
            if (numberToContinue < tileReference.Count)
            {
                StartCoroutine(NextPathPlease());
            }
            else
            {
                bMC.TurnButtonsBackOn();
                Debug.Log("Finished Implementing Path Structure");
            }
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
           
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
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
            
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
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
            
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
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
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
            
            if (numberToContinue < tileReference.Count)
            {
                StartCoroutine(NextPathPlease());
            }
            else
            {
                bMC.TurnButtonsBackOn();
                Debug.Log("Finished Implementing Path Structure");
            }
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
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
            
            if (numberToContinue < tileReference.Count)
            {
                StartCoroutine(NextPathPlease());
            }
            else
            {
                bMC.TurnButtonsBackOn();
                Debug.Log("Finished Implementing Path Structure");
            }
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
            
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
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
            
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
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
            
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
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
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
            
            if (numberToContinue < tileReference.Count)
            {
                StartCoroutine(NextPathPlease());
            }
            else
            {
                bMC.TurnButtonsBackOn();
                Debug.Log("Finished Implementing Path Structure");
            }
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
           
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
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
            
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
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
            
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
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
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
            
            if (numberToContinue < tileReference.Count)
            {
                StartCoroutine(NextPathPlease());
            }
            else
            {
                bMC.TurnButtonsBackOn();
                Debug.Log("Finished Implementing Path Structure");
            }
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
            
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
            // Start to Curve Up
            tileReference[numberToContinue - 1].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue - 1].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue - 1].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            tileReference[numberToContinue].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 1].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 2].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 3].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
            // Starting to Stright
            tileReference[numberToContinue + 1].GetComponent<Image>().sprite = pDB.pathData[5].pathSprite.sprite;
            tileReference[numberToContinue].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            tileReference[numberToContinue + 1].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            tileReference[numberToContinue + 2].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
            
            if (numberToContinue < tileReference.Count)
            {
                StartCoroutine(NextPathPlease());
            }
            else
            {
                bMC.TurnButtonsBackOn();
                Debug.Log("Finished Implementing Path Structure");
            }
            yield return null;
        }

        private IEnumerator StriaghtVerticlePathAbove()
        {
            numberToContinue = Mathf.Clamp(numberToContinue - 75, 0, tileReference.Count - 1);
            
            tileReference[numberToContinue + 3].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            tileReference[numberToContinue + 4].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            tileReference[numberToContinue + 5].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            tileReference[numberToContinue + 6].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
           
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
            // Start to Curve Up
            tileReference[numberToContinue + 3].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 4].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 5].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 6].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
            // Starting to Stright
            tileReference[numberToContinue + 3].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            tileReference[numberToContinue + 4].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            tileReference[numberToContinue + 5].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            tileReference[numberToContinue + 6].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
            
            if (numberToContinue < tileReference.Count)
            {
                StartCoroutine(NextPathPlease());
            }
            else
            {
                bMC.TurnButtonsBackOn();
                Debug.Log("Finished Implementing Path Structure");
            }
            yield return null;
        }

        private IEnumerator StraighVerticlePathHighestPoint()
        {
            numberToContinue = Mathf.Clamp(numberToContinue - 75, 0, tileReference.Count - 1);
            
            tileReference[numberToContinue + 7].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            tileReference[numberToContinue + 8].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            tileReference[numberToContinue + 9].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            tileReference[numberToContinue + 10].GetComponent<Image>().sprite = pDB.pathData[1].pathSprite.sprite;
            tileReference[numberToContinue + 11].GetComponent<Image>().sprite = pDB.pathData[5].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 11].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 180f);
            tileReference[numberToContinue + 11].GetComponent<RectTransform>().rotation = rectTransform.rotation;
           
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
            // Start to Curve Up
            tileReference[numberToContinue + 7].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 8].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 9].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 10].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 11].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 11].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 11].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
            // Starting to Stright
            tileReference[numberToContinue + 7].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            tileReference[numberToContinue + 8].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            tileReference[numberToContinue + 9].GetComponent<Image>().sprite = pDB.pathData[3].pathSprite.sprite;
            tileReference[numberToContinue + 10].GetComponent<Image>().sprite = pDB.pathData[0].pathSprite.sprite;
            tileReference[numberToContinue + 11].GetComponent<Image>().sprite = pDB.pathData[2].pathSprite.sprite;
            rectTransform = tileReference[numberToContinue + 11].GetComponent<RectTransform>();
            rectTransform.rotation = Quaternion.Euler(0, 0, 90f);
            tileReference[numberToContinue + 11].GetComponent<RectTransform>().rotation = rectTransform.rotation;
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
           
            if (numberToContinue < tileReference.Count)
            {
                StartCoroutine(NextPathPlease());
            }
            else
            {
                bMC.TurnButtonsBackOn();
                Debug.Log("Finished Implementing Path Structure");
            }
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
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
            
            if (numberToContinue < tileReference.Count)
            {
                StartCoroutine(NextPathPlease());
            }
            else
            {
                bMC.TurnButtonsBackOn();
                Debug.Log("Finished Implementing Path Structure");
            }
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
           
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
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
            
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
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
            
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
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
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
           
            if (numberToContinue < tileReference.Count)
            {
                StartCoroutine(NextPathPlease());
            }
            else
            {
                bMC.TurnButtonsBackOn();
                Debug.Log("Finished Implementing Path Structure");
            }
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
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
            
            if (numberToContinue < tileReference.Count)
            {
                StartCoroutine(NextPathPlease());
            }
            else
            {
                bMC.TurnButtonsBackOn();
                Debug.Log("Finished Implementing Path Structure");
            }
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
           
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
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
            
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
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
            
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
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
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
            
            if (numberToContinue < tileReference.Count)
            {
                StartCoroutine(NextPathPlease());
            }
            else
            {
                bMC.TurnButtonsBackOn();
                Debug.Log("Finished Implementing Path Structure");
            }
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
           
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
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
            
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
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
            
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
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
            numberToContinue = Mathf.Clamp(numberToContinue + 25, 0, tileReference.Count - 1);
            
            if (numberToContinue < tileReference.Count)
            {
                StartCoroutine(NextPathPlease());
            }
            else
            {
                bMC.TurnButtonsBackOn();
                Debug.Log("Finished Implementing Path Structure");
            }
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
