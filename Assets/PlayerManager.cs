using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerManager : NetworkBehaviour
{
    [SyncVar]
    [SerializeField]
    private string displayName = "Missing Name";
    [SyncVar(hook = nameof(HandleDisplayColourUpdate))]
    [SerializeField]
    private Color displayColour = Color.black;
    [SerializeField]
    private Renderer displayColourRenderer;
    public Material PlayerM;
    [Server]
    public void SetDisplayName(string newDisplayName)
    {
        displayName = newDisplayName;
    }
    [Server]
    public void SetDisplayColour(Color newDisplayColour)
    {
        displayColour = newDisplayColour;
    }
    private void HandleDisplayColourUpdate(Color oldColour,Color newColour)
    {
        PlayerM.color= displayColour;
    }
}
