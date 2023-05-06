export default function CreateClan({modal, setModal, setLista}){

    let ime, prezime, datumRodjenja, datumUclanjenja, datumZaveta, adresa, telefon, kategorija;

    function dodajClana(){

        if (ime.value === "" || prezime.value === "" || datumRodjenja.value === "" || datumUclanjenja.value === ""){
            alert("Neka polja nisu uneta kako treba!");
            return;
        }

        const options = {
            method: "POST", 
            headers: {
                'Content-Type' : 'application/json'
            },
            body: JSON.stringify({
                ime: ime.value,
                prezime: prezime.value,
                datumRodjenja: datumRodjenja.value,
                datumUclanjenja: datumUclanjenja.value,
                datumZaveta: datumZaveta.value === "" ? null : datumZaveta.value,
                adresa: adresa.value,
                telefon: telefon.value,
                kategorija: kategorija.value === "" ? null : parseInt(kategorija.value)
            })
        };

        fetch("https://localhost:7298/Clan/CreateClan", options)
        .then (res => {
            if (res.status !== 200) {
                alert("Problem sa upisivanjem");
            }else {
                ime.value = "";
                prezime.value = "";
                datumRodjenja.value = "";
                datumUclanjenja.value = "";
                datumZaveta.value = "";
                adresa.value = "";
                telefon.value = "";
                kategorija.value = "";
                setModal(false);
            }
            return res.json();
        }).then(data => setLista(curr => [...curr, data]));
    }

    return (
        <div className={`modal ${modal ? "show" : ""}`}>
            <div className="shade" onClick={() => setModal(false)}></div>
            <div className="form" style={{display:"flex", flexDirection:"column"}}>
                <h2>Dodaj Clana</h2>
                <div>
                    <label className="required" htmlFor="ime">Ime: </label>
                    <input id="ime" name="ime" type="text" ref={el => ime = el} />
                </div>
                <div>
                    <label className="required" htmlFor="prezime">Prezime: </label>
                    <input id="prezime" name="prezime" type="text" ref={el => prezime = el} />
                </div>
                <div>
                    <label className="required" htmlFor="datumRodjenja">Datum Rodjenja: </label>
                    <input id="datumRodjenja" name="datumRodjenja" type="date" ref={el => datumRodjenja = el} />
                </div>
                <div>
                    <label className="required" htmlFor="datumUclanjenja">Datum Uclanjenja: </label>
                    <input id="datumUclanjenja" name="datumUclanjenja" type="date" ref={el => datumUclanjenja = el} />
                </div>
                <div>
                    <label htmlFor="datumZaveta">Datum Davanja Zaveta: </label>
                    <input id="datumZaveta" name="datumZaveta" type="date" ref={el => datumZaveta = el} />
                </div>
                <div>
                    <label htmlFor="adresa">Adresa: </label>
                    <input id="adresa" name="adresa" type="text" ref={el => adresa = el} />
                </div>
                <div>
                    <label htmlFor="telefon">Telefon: </label>
                    <input id="telefon" name="telefon" type="tel" ref={el => telefon = el} />
                </div>
                <div>
                    <label htmlFor="kategorija">Kategorija: </label>
                    <select id="kategorija" name="kategorija" defaultValue="" ref={el => kategorija = el}>
                        <option value="" disabled hidden>Izaberite Kategoriju</option>
                        <option value={0}>Poletarci</option>
                        <option value={1}>Pčelice</option>
                        <option value={2}>Mladji Izvidjači</option>
                        <option value={3}>Mladje Planinke</option>
                        <option value={4}>Stariji Izvidjači</option>
                        <option value={5}>Starije Planinke</option>
                        <option value={6}>Brdjani</option>
                        <option value={7}>Brdjanke</option>
                    </select>
                </div>
                <button onClick={dodajClana}>Dodaj Clana</button>
            </div>
        </div>
    );
}