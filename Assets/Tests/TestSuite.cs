using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestSuite
    {
        private MainCharacterMovement mainCharacter;

        [Test]
        public void Horizontal_Main_Character_Movement_Test()
        {
            //Arrange
            GameObject gameObject = MonoBehaviour.Instantiate(GameObject.Find("Protagonista"));
            var horizontalInput = Input.GetAxis("Horizontal");
            mainCharacter = gameObject.GetComponent<MainCharacterMovement>();
            float speed = 1.5f;

            //Act
            mainCharacter.CharacterMove(speed);
            Wait(15f);

            //Assert
            var initialPosition = mainCharacter.transform.position.y;            

            Assert.Less(mainCharacter.transform.position.y, initialPosition);

            GameObject.Destroy(mainCharacter.gameObject);
        }

        IEnumerator Wait(float waitTime)
        {
            yield return new WaitForSeconds(waitTime);
        }
    }
}
