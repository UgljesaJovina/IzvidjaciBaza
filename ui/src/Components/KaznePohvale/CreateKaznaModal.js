export default function CreateKaznaModal({ modal, setModal }) {

    let datumDobijanja, datumIsteka, dodeljivac, razlog;

    function DodeliKaznu() {
        
    }

    return (
        <div className={`modal ${modal ? "show" : ""}`}>
            <div className="shade" onClick={() => setModal(false)}></div>
            <div className="form">
                <div><label>Dodajte Kaznu</label></div>
                <hr />
                <div>
                    <label className="required" htmlFor="dodeljivac">Dodeljivac kazne: </label>
                    <input id="dodeljivac" name="dodeljivac" type="text" ref={el => dodeljivac = el} />
                </div>
                <div>
                    <label className="required" htmlFor="datumDobijanja">Datum dobijanja kazne:</label>
                    <input id="datumDobijanja" name="datumDobijanja" type="date" ref={el => datumDobijanja = el} />
                </div>
                <div>
                    <label className="required" htmlFor="datumIsteka">Datum isteka kazne:</label>
                    <input id="datumIsteka" name="datumIsteka" type="date" ref={el => datumIsteka = el} />
                </div>
                <div>
                    <label>Razlog za kaznu: </label>
                    <textarea style={{verticalAlign:"top", resize:"none", width:"60%", 
                        height:"200px", fontSize:"18px", border:"none", backgroundColor:"darkslategray", color:"white", padding:"1%"}}
                        id="razlog" name="razlog" ref={el => razlog = el} ></textarea>
                </div>
                <div style={{marginTop:"2%"}}><button style={{marginLeft:"50%", transform:"translateX(-50%)"}}>Dodeli Kaznu</button></div>
            </div>
        </div>
    );
}