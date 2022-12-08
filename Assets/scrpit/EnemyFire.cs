using UnityEngine;

namespace KIDSU
{
    /// <summary>
    /// �ĤH�g���t��
    /// </summary>
    public class EnemyFire : FireSystem
    {
        [SerializeField, Header("�ͦ����j"), Range(0, 3)]
        private float interval = 1.5f;

        private void Awake()
        {
            // �I�s�ۭq��k
            //SpawnBullet();
        }

        private void OnBecameVisible()
        {
            // ���𭫽ƩI�s��k(��k�W�١A����ɶ��A���j)
            InvokeRepeating("SpawnBullet", 0, interval);
        }

        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }
    }
}