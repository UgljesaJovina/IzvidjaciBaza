import { useNavigate } from "react-router"

export default function ShortAkcija({id, naziv}) {

    const navigate = useNavigate();

    return (
        <label onClick={() => navigate(`akcija/${id}`)} className="shortObj">{naziv}</label>
    )
}