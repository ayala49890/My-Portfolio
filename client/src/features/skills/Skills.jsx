import { useEffect } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { fetchSkills } from './skillsSlice';

export default function Skills() {
  const dispatch = useDispatch();
  const { data: skills, status, error } = useSelector((state) => state.skills);

  useEffect(() => {
    if (status === 'idle') {
      dispatch(fetchSkills()); 
    }
  }, [dispatch, status]);

  if (status === 'loading') return <p>loading..</p>;
  if (status === 'failed') return <p>error: {error}</p>;

  return (
    <div>
      <h2>my skills</h2>
      <ul>
        {skills.map((skill) => (
          <li key={skill.id}>{skill.name}</li>
        ))}
      </ul>
    </div>
  );
}
