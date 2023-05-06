export default function ShortObjectList({ title, addFunc: openFunc, children }) {
    return (
        <div>
            <div className="listTitle">
                <label>{title}</label>
                <button onClick={() => openFunc(true)}>+</button>
            </div>
            <div className="objList">
                {children}
            </div>
        </div>
    );
}