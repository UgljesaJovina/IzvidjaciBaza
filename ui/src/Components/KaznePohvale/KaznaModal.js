export default function KaznaModal({kazna, modal, setModal}) {

    if (!kazna) { return; }

    return (
        <div className={`modal ${modal ? "show" : ""}`}>
            <div className="shade" onClick={() => setModal(false)}></div>
            <div className="form" style={{height:"50%"}}>
                <div><label>Kaznu dodelio: {kazna.dodeljivacKazne ? kazna.dodeljivacKazne : "Nije upisano"}</label></div>
                <hr />
                <div><label>Datum dobijanja kazne: {new Date(kazna.datumDobijanja).toLocaleDateString("sr")}</label></div>
                <div><label>Datum isteka kazne: {new Date(kazna.datumIsteka).toLocaleDateString("sr")}</label></div>
                <div>
                    <label>Razlog za kaznu: </label>
                    <textarea value={kazna.opis} readOnly style={{verticalAlign:"top", resize:"none", width:"60%", 
                        height:"200px", fontSize:"18px", border:"none", backgroundColor:"darkslategray", color:"white", padding:"1%"}} ></textarea>
                </div>
            </div>
        </div>
    );
}