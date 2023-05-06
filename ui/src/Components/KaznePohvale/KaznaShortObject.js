export default function KaznaShortObject({id, text, expired, delFunc, openModal}) {
    return (
        <div className="kaznaShortObject" style={{display: "flex"}}>
            <label onClick={() => openModal(id)} className={`shortObject ${expired ? "expired" : ""}`} >{text}</label>
            <button onClick={() => delFunc(id)}>-</button>
        </div>
    );
}