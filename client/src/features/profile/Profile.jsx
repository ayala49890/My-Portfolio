import { useEffect } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { fetchProfile } from './profileSlice';

export default function Profile() {
  const dispatch = useDispatch();
  const { data: profile, status, error } = useSelector((state) => state.profile);

  useEffect(() => {
    if (status === 'idle') {
      dispatch(fetchProfile()); 
    }
  }, [dispatch, status]);

  if (status === 'loading') return <p>loading..</p>;
  if (status === 'failed') return <p>error: {error}</p>;

  return (
    <div>
      <h2>my profile</h2>
      <ul>
        {Object.entries(profile).filter(([key]) => key !== 'id')
        .map(([key, value]) => (
          <li key={key}>
             {String(value)}
          </li>
        ))}
      </ul>
    </div>
  );
}
