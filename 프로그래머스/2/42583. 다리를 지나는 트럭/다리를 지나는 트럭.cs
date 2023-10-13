using System;
using System.Collections.Generic;

public class Solution {
    // 트럭 하나가 다리를 지나는데 걸리는 시간이 없는데? -> '일차선 다리' 다리의 길이만큼 걸리네
    // 
    Queue<int> bridge = new Queue<int>();
    int onBridgeWeight = 0;
    int truckIndex = 0;
    int maxWeight = 0;
    int maxLength = 0;
    
    public int solution(int bridge_length, int weight, int[] truck_weights) 
    {   
        int answer = bridge_length;
        InitBridge(bridge_length, weight);
        while(truckIndex != truck_weights.Length)
        {
            OffBridge();
            OnBridge(truck_weights[truckIndex]);
            answer++;
        }
        
        return answer;
    }
    
    public void InitBridge(int bridge_length, int weight)
    {
        maxWeight = weight;
        maxLength = bridge_length;
        
        for(int i =0 ;i< bridge_length; i++)
        {
            bridge.Enqueue(0);
        }
    }
    
    public void OffBridge()
    {
        onBridgeWeight -= bridge.Dequeue();
    }
    
    public void OnBridge(int truck)
    {
        if (onBridgeWeight + truck <= maxWeight)
        {
            onBridgeWeight += truck;
            bridge.Enqueue(truck);
            truckIndex++;
        }
        else
        {
            bridge.Enqueue(0);
        }
    }
}