import { useEffect, useState } from "react";
import "./App.css";
import { Topic } from "./types/TopicsType";

function App() {
  const [topics, setTopics] = useState<Topic[]>([]);

  useEffect(() => {
    const loadTopics = async () => {
      const loadedData = await fetch("topic")
        .then((data) => data.json())
        .then((data) => data);

      setTopics(loadedData);
    };

    loadTopics();
  }, []);

  return (
    <>
      <h1>Bloggy</h1>
      <div>
        {topics.map((x) => {
          return <div>{x.description}</div>;
        })}
      </div>
    </>
  );
}

export default App;
