import { useNavigate } from "react-router";

export default function ShortObject({naziv, id, path}){
    const navigate = useNavigate();

    return (<label onClick={() => navigate(`${path}/${id}`)}>{naziv}</label>);
}