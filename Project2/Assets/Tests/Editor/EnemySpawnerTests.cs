using System.Collections;
using NUnit.Framework;
using UnityEditor;
using UnityEngine;
using UnityEngine.TestTools;

namespace Assets.Tests.Editor
{
    public class EnemySpawnerTests {
     

        //[Test]
        //public void EnemySpaswnerTestsSimplePasses() {
        //	// Use the Assert class to test conditions.
        //}

        //// A UnityTest behaves like a coroutine in PlayMode
        //// and allows you to yield null to skip a frame in EditMode
        //[UnityTest]
        //public IEnumerator EnemySpaswnerTestsWithEnumeratorPasses() {
        //	// Use the Assert class to test conditions.
        //	// yield to skip a frame
        //	
        //}

        [UnityTest]
        public IEnumerator _Instantiantes_GameObject_From_Prefab()
        {
            var enemyPrefab = Resources.Load("Tests/enemy");
            var enemySpawner = new GameObject().AddComponent<EnemySpawner>();
        
            //construct method will setup state
            enemySpawner.Construct(enemyPrefab,0,1);

            yield return null;

            var spawnedEnemy = GameObject.FindWithTag("Enemy");
            var prefabOfTheSpawnedEnemy = PrefabUtility.GetPrefabParent(spawnedEnemy);

            Assert.AreEqual(enemyPrefab, prefabOfTheSpawnedEnemy);
        }

        [UnityTest]
        public IEnumerator _Instantiates_GameObject_At_Random_Position_On_Circle_Boundary()
        {
            var enemyPrefab = Resources.Load("Tests/enemy");
            var enemySpawner = new GameObject().AddComponent<EnemySpawner>();
            //construct method will setup state
            enemySpawner.Construct(enemyPrefab, 0, 1);
            var random = NSubstitute.Substitute.For<System.Random>();
            random.Next(Arg.Any<int>(),Arg.Any<int>()).Returns(270);
            enemySpawner.Random = random;


            yield return null;

            var spawnedEnemy = GameObject.FindWithTag("Enemy");
            //270 degrees
            var expectedPosition = new Vector3(0, 0, -1);

            Assert.AreEqual(expectedPosition,spawnedEnemy.transform.position);
        
        

        
        }

        //will be run after test
        [TearDown]
        public void AfterEveryTest()
        {
            foreach (var gameObject in GameObject.FindGameObjectsWithTag("Enemy"))
                Object.Destroy(gameObject);

            foreach (var gameObject in Object.FindObjectsOfType<EnemySpawner>())
                Object.Destroy(gameObject);

        }
    }
}
