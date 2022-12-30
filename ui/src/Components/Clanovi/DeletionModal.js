export default function DeletionModal({message, ok, modal, setModal}) {
    return (
        <div className={`modal ${modal ? "show" : ""}`}>
            <div className="shade" onClick={() => setModal(false)}></div>
            <div className="messageContainer">
                <label>{message}</label>
                <button style={{marginLeft: "auto"}} onClick={() => setModal(false)}>Cancel</button>
                <button style={{marginLeft: "3%", backgroundColor: "#f93e3e"}} onClick={ok}>Ok</button>
            </div>
        </div>
    )
}