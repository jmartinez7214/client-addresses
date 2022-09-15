import { useEffect, useState } from "react";
import { Address } from "../types";
import { notification } from "antd";
import { getClientAddresses } from "../services/getClientAddresses";
import { useParams } from "react-router-dom";
import { parseParamToInt } from "../utils/parseParams";

const useClientAddresses = () => {
  const [clientAddresses, setClientAddresses] = useState<Address[]>();
  const { id } = useParams();

  useEffect(() => {
    getClientAddresses(parseParamToInt(id))
      .then(setClientAddresses)
      .catch(() => {
        notification["error"]({
          message: "Server error, try later.",
        });
      });
  }, []);

  return {
    clientAddresses,
  };
};

export default useClientAddresses;
