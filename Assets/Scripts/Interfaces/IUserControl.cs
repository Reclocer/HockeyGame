using UnityEngine;

public interface IUserControl: IUnityComponent
{
    Vector3 CursorPosition { get; }
    //void MoveStickWithCursor();
}
