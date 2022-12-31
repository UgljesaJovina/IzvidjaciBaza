export default function KaznaShortObject({id, text, delFunc, openModal}) {
    return (
        <div className="kaznaShortObject" style={{display: "flex"}}>
            <label onClick={() => openModal(id)} >{text}</label>
            <button onClick={() => delFunc(id)}>-</button>
        </div>
    );
}