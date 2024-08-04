using UnityEngine;

namespace OneTurretArmy
{
   public class ButtonMapUIController : MonoBehaviour
   {
      [SerializeField] private GameObject buttonOne;
      [SerializeField] private GameObject buttonTwo;
      
      private void Awake()
      {
         TurnButtonsOff();
      }

      public void TurnButtonsBackOn()
      {
         buttonOne.SetActive(true);
         buttonTwo.SetActive(true);
      }
      
      public void TurnButtonsOff()
      {
         buttonOne.SetActive(false);
         buttonTwo.SetActive(false);
      }
   }
}
