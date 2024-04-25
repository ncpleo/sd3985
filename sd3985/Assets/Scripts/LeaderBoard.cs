using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class LeaderboardManager : MonoBehaviour
{
    public Text[] playerRankTexts; // Assign in inspector, order corresponds to P1, P2, P3, P4

    private void Update()
    {
        // Assuming you have a PlayerController script that holds the player's y position
        var playerPositions = new[]
        {
            new { Name = "P1", YPosition = GameObject.Find("P1").GetComponent<PlayerController>().YPosition },
            new { Name = "P2", YPosition = GameObject.Find("P2").GetComponent<PlayerController>().YPosition },
            new { Name = "P3", YPosition = GameObject.Find("P3").GetComponent<PlayerController>().YPosition },
            new { Name = "P4", YPosition = GameObject.Find("P4").GetComponent<PlayerController>().YPosition }
        };

        // Sort players by y position
        var sortedPlayers = playerPositions.OrderByDescending(p => p.YPosition).ToArray();

        // Update UI Text elements with the sorted ranks
        for (int i = 0; i < sortedPlayers.Length; i++)
        {
            playerRankTexts[i].text = $"{sortedPlayers[i].Name}: Rank {i + 1}";
        }
    }
}