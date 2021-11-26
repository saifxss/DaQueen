using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using TMPro;

public class PlayerManager : NetworkBehaviour
{
    [SyncVar(hook =nameof(HandleDisplayNameUpdate))]
    [SerializeField]
    private string displayName = "Missing Name";
    [SyncVar(hook = nameof(HandleDisplayColourUpdate))]
    [SerializeField]
    private Color displayColour = Color.black;
    [SerializeField]
    private TMP_Text displayNameText=null;
    //DisplayColourRenderer
    [SerializeField]
    private Renderer displayColourRendererHe;
    [SerializeField]
    private Renderer displayColourRendererC;
    [SerializeField]
    private Renderer displayColourRendererHi;
    [SerializeField]
    private Renderer displayColourRendererB;
    [SerializeField]
    private Renderer displayColourRendererLL;
    [SerializeField]
    private Renderer displayColourRendererLR;
    [SerializeField]
    private Renderer displayColourRendererHL;
    [SerializeField]
    private Renderer displayColourRendererHR;
    [SerializeField]
    private Renderer displayColourRendererCHR;
    [SerializeField]
    private Renderer displayColourRendererCHL;
    [SerializeField]
    private Renderer displayColourRendererCLR;
    [SerializeField]
    private Renderer displayColourRendererCLL;

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
        displayColourRendererHe.material.color= displayColour;
        displayColourRendererC.material.color = displayColour;
        displayColourRendererHi.material.color = displayColour;
        displayColourRendererB.material.color = displayColour;
        displayColourRendererLL.material.color = displayColour;
        displayColourRendererLR.material.color = displayColour;
        displayColourRendererHL.material.color = displayColour;
        displayColourRendererHR.material.color = displayColour;
        displayColourRendererCHR.material.color = displayColour;
        displayColourRendererCHL.material.color = displayColour;
        displayColourRendererCLR.material.color = displayColour;
        displayColourRendererCLL.material.color = displayColour;
    }
    private void HandleDisplayNameUpdate(string oldName, string newName)
    {
        displayNameText.text = newName;
    }   
}
