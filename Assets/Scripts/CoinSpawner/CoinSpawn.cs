using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
    public GameObject coinPrefab;

    void Update()
    { //codigo antigo, versao que os astecas usavam em sua epoca

       /* if(Coletaveis.total<1){
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-15, 15), 1, Random.Range(-20, -29));
            Instantiate(coinPrefab, randomSpawnPosition, Quaternion.identity);
        }
        else if(Coletaveis.total<2){
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-17, -22), 1, Random.Range(-9, -29));
            Instantiate(coinPrefab, randomSpawnPosition, Quaternion.identity);
        }
        else if(Coletaveis.total<3){
            Vector3 randomSpawnPosition = new Vector3(Random.Range(9, 5), 1, Random.Range(6, -30));
            Instantiate(coinPrefab, randomSpawnPosition, Quaternion.identity);
        }
        else if(Coletaveis.total<4){
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-8, 11), 1, Random.Range(6, 2));
            Instantiate(coinPrefab, randomSpawnPosition, Quaternion.identity);
        }
        if(ColetaveisContador.counttotal==4 && Coletaveis.total < 5){
            Vector3 randomSpawnPosition = new Vector3(Random.Range(23, -26), 1, Random.Range(-22, -26));
            Instantiate(coinPrefab, randomSpawnPosition, Quaternion.identity);
        } */


        //codigo mais bem trabalhado, pique codigo que as fragatas europeias usavam 

        switch (Coletaveis.total){
            case 0:
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-26, 15), 1, Random.Range(-15, -28));
            Instantiate(coinPrefab, randomSpawnPosition, Quaternion.identity);
            break;
            case 1:
            randomSpawnPosition = new Vector3(Random.Range(-4, -22), 1, Random.Range(-8, -27));
            Instantiate(coinPrefab, randomSpawnPosition, Quaternion.identity);
            break;
            case 2:
            randomSpawnPosition = new Vector3(Random.Range(-15, 23), 1, Random.Range(-20, -28));
            Instantiate(coinPrefab, randomSpawnPosition, Quaternion.identity);
            break;
            case 3:
            randomSpawnPosition = new Vector3(Random.Range(-8, 8), 1, Random.Range(6, 2));
            Instantiate(coinPrefab, randomSpawnPosition, Quaternion.identity);
            break;
            case 4:
            randomSpawnPosition = new Vector3(Random.Range(-8, -4), 1, Random.Range(5, -29));
            Instantiate(coinPrefab, randomSpawnPosition, Quaternion.identity);
            break;
        }
        
        if(ColetaveisContador.counttotal==5 && Coletaveis.total < 6){
            Vector3 randomSpawnPosition = new Vector3(Random.Range(23, -26), 1, Random.Range(-22, -26));
            Instantiate(coinPrefab, randomSpawnPosition, Quaternion.identity);
        } 



    }
}
