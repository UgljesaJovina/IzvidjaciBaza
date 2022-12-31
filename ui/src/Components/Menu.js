import { Outlet, Link } from "react-router-dom";

export default function Menu(){
    return (
        <>
            <div className="menu">
                <h1>MENU</h1>
                <Link to="/" className="link">Clanovi</Link>
                <Link to="/vodovi" className="link">Vodovi</Link>
                <Link to="/akcije" className="link">Akcije</Link>
                <Link to="/tecajevi" className="link">Tecajevi</Link>
            </div>
            <Outlet/>
        </>
    );
}