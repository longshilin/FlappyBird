using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This behavior handles updating an UI text with
/// the current player score
/// </summary>
[RequireComponent(typeof(Text))]
public class GameScoreLabel : MonoBehaviour, IAnyScoreListener, IAnyGameStartedListener
{
    private Text _label;

    private void Start()
    {
        _label = GetComponent<Text>();

        var contexts = Contexts.sharedInstance;
        var e = contexts.game.CreateEntity();
        e.AddAnyScoreListener(this);
        e.AddAnyGameStartedListener(this);
    }

    public void OnAnyScore(GameEntity entity, int value)
    {
        _label.text = value.ToString();
    }

    public void OnAnyGameStarted(GameEntity entity)
    {
        _label.text = "0";
    }
}