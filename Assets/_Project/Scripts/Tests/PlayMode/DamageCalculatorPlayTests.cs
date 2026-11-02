// using System.Collections;
// using NUnit.Framework;
// using UnityEngine;
// using UnityEngine.TestTools;

// public class DamageCalculatorPlayTests
// {
//     [UnityTest]
//     public IEnumerator GameObject_CanBeCreated()
//     {
//         // GameObject 생성
//         var gameObject = new GameObject("TestObject");

//         // 실제 Unity 런타임에서 한 프레임 대기
//         yield return null;

//         // 생성 여부 확인
//         Assert.IsNotNull(gameObject);
//         Assert.AreEqual("TestObject", gameObject.name);

//         // 테스트 후 정리
//         Object.Destroy(gameObject);
//     }
// }